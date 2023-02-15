using Common.Dtos;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailController : ControllerBase
    {
        private readonly IDataService<DetailDto> _DetailServise;
        public DetailController(IDataService<DetailDto> _DetailServise)
        {
            this._DetailServise = _DetailServise;
        }


        [HttpGet]
        public async Task<List<DetailDto>> Get()
        {
            return await _DetailServise.GetAllAsync();

        }


        [HttpGet("{id}")]
        public async Task<DetailDto> Get(string id)
        {
            return await _DetailServise.GetByIdAsync(id);

        }


        [HttpPost]
        public async Task<DetailDto> Post([FromBody] DetailPostModel Detail)
        {
            return await _DetailServise.AddAsync(new DetailDto {Idenentity=Detail.Idenentity,FirstName=Detail.FirstName,LastName=Detail.LastName,BornDate=Detail.BornDate,Gender=Detail.Gender,Hmo=Detail.Hmo });
        }


        [HttpPut]
        public async Task<DetailDto> Put([FromBody] DetailDto Detail)
        {
            return await _DetailServise.UpdateAsync(Detail);
        }


        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _DetailServise.DeleteAsync(id);
        }
    }
}
