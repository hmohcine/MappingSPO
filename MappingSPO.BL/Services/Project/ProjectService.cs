using AutoMapper;
using MappingSPO.Framework.BL.Contracts.Project;
using MappingSPO.Framework.BL.VModels.SPO;
using MappingSPO.Framework.DL.Contracts;
using MappingSPO.Project.DL.Contracts;
using MappingSPO.Project.DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingSPO.Framework.BL.Services.Project
{
    public class ProjectService : IProjectService
    {
        private readonly IDataRepositoryFactory _dataRepositoryFactory;
        private readonly IMapper _mapper;

        public ProjectService(IMapper mapper, IDataRepositoryFactory dataRepositoryFactory)
        {
            _mapper = mapper;
            _dataRepositoryFactory = dataRepositoryFactory;
        }

        public List<VModels.SPO.Project> GetAllProjects()
        {
            var repo = _dataRepositoryFactory.GetDataRepository<IProjectRepository>();
            var entity = repo.GetAllProjects().ToList();
            var ListProjects = entity.Select(f => new VModels.SPO.Project
            {
                ProjectNumber = f.ProjectNumber,
                ProjectName=f.ProjectName,
                ProjectState=f.ProjectState,
                Owner=f.Owner,
                ProjectVerantWoordelijke1=f.ProjectVerantWoordelijke1,
                ProjectVerantWoordelijke2=f.ProjectVerantWoordelijke2,
            }).ToList();
            var result = _mapper.Map<List<VModels.SPO.Project>>(ListProjects);
            return result;
        }
    }
}
