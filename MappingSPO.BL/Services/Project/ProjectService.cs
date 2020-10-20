using AutoMapper;
using MappingSPO.Framework.BL.Contracts.Project;
using MappingSPO.Framework.BL.VModels.Project;
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

        public List<ProjectEntity> GetAllProjects()
        {
            var repo = _dataRepositoryFactory.GetDataRepository<IProjectRepository>();
            var entity = repo.GetAllProjects().ToList();
            var result = _mapper.Map<List<ProjectEntity>>(entity);
            return result;
        }
    }
}
