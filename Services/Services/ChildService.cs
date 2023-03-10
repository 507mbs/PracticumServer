using AutoMapper;
using Common.Dtos;
using Repositories.Entities;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ChildService : IDataService<ChildDto>
    {
        private readonly IDataRepository<Child> dataRepository;
        private readonly IMapper mapper;
        public ChildService(IDataRepository<Child> dataRepository, IMapper mapper)
        {
            this.dataRepository = dataRepository;
            this.mapper = mapper;
        }

        public async Task<ChildDto> AddAsync(ChildDto entity)
        {
            Child newChild = mapper.Map<Child>(entity);
            var n = await dataRepository.AddAsync(newChild);
            var newOne = mapper.Map<ChildDto>(n);
            return newOne;
        }

        public async Task DeleteAsync(string id)
        {
            await dataRepository.DeleteAsync(id);
        }

        public async Task<List<ChildDto>> GetAllAsync()
        {
            return mapper.Map<List<ChildDto>>(await dataRepository.GetAllAsync());
        }

        public async Task<ChildDto> GetByIdAsync(string id)
        {
            return mapper.Map<ChildDto>(await dataRepository.GetByIdAsync(id));
        }

        public async Task<ChildDto> UpdateAsync(ChildDto entity)
        {
            return mapper.Map<ChildDto>(await dataRepository.UpdateAsync(mapper.Map<Child>(entity)));
        }
    }
}
