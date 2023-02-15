using AutoMapper;
using Common.Dtos;
using Repositories.Entities;
using Repositories.Interface;
using Services.Interface;

namespace Services.Services
{
    public class DetailService : IDataService<DetailDto>
    {
        private readonly IDataRepository<Detail> dataRepository;
        private readonly IMapper mapper;
        public DetailService(IDataRepository<Detail> dataRepository, IMapper mapper)
        {
            this.dataRepository = dataRepository;
            this.mapper = mapper;
        }

        public async Task<DetailDto> AddAsync(DetailDto entity)
        {
            Detail newDetail = mapper.Map<Detail>(entity);
            var n = await dataRepository.AddAsync(newDetail);
            var newOne = mapper.Map<DetailDto>(n);
            return newOne;
        }

        public async Task DeleteAsync(string id)
        {
            await dataRepository.DeleteAsync(id);
        }

        public async Task<List<DetailDto>> GetAllAsync()
        {
            return mapper.Map<List<DetailDto>>(await dataRepository.GetAllAsync());
        }

        public async Task<DetailDto> GetByIdAsync(string id)
        {
            return mapper.Map<DetailDto>(await dataRepository.GetByIdAsync(id));
        }

        public async Task<DetailDto> UpdateAsync(DetailDto entity)
        {
            return mapper.Map<DetailDto>(await dataRepository.UpdateAsync(mapper.Map<Detail>(entity)));
        }
    }
}
