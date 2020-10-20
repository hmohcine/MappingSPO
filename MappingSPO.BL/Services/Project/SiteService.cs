using AutoMapper;
using MappingSPO.Framework.BL.Contracts.Project;
using MappingSPO.Framework.BL.VModels.Project;
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

        public List<SiteVM> GetAllSites()
        {
            var repo = _dataRepositoryFactory.GetDataRepository<ISiteRepository>();
            var entity = repo.GetAllSites();
            var result = _mapper.Map<List<SiteVM>>(entity);
            return result;
        }
    }
}
