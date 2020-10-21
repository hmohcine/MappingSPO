using AutoMapper;
using MappingSPO.Framework.BL.Contracts.Project;
using MappingSPO.Framework.BL.VModels.Project;
using MappingSPO.Framework.BL.VModels.SPO;
using MappingSPO.Framework.DL.Contracts;
using MappingSPO.Project.DL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingSPO.Framework.BL.Services.Project
{
    public class SiteService : ISiteService
    {
        private readonly IDataRepositoryFactory _dataRepositoryFactory;
        private readonly IMapper _mapper;

        public SiteService(IMapper mapper, IDataRepositoryFactory dataRepositoryFactory)
        {
            _mapper = mapper;
            _dataRepositoryFactory = dataRepositoryFactory;
        }
        public List<Site> GetAllSites()
        {
            var repo = _dataRepositoryFactory.GetDataRepository<ISiteRepository>();
            var repoProject = _dataRepositoryFactory.GetDataRepository<IProjectRepository>();
            var entity = repo.GetAllSites();
            var entityProject = repoProject.GetProjectsWithSite();
            var ListSites = entity.Select(f => new Site
            {
                WerfId = f.WerfId,
                WerfName = f.WerfName,
                WerfNumber = f.WerfNumber,
                WerfState = f.WerfState,
                Bedrijf = f.CompanyId.ToString(),
                ProjectName = (entityProject.Any(c => c.WerfId == f.WerfId))
                            ? entityProject.FirstOrDefault(x => x.WerfId == f.WerfId).ProjectId.ToString() : null,
                VerantWoordelijke1 = f.ProjectLeider,
                  VerantWoordelijke2= f.Werfleider,
            }).ToList();
            var result = _mapper.Map<List<Site>>(ListSites);
            return result;
        }
    }
}
