
using Common.Dtos;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;
using WebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IDataService<ChildDto> _childServise;
        public ChildController(IDataService<ChildDto> _childServise)
        {
            this._childServise = _childServise;
        }


        [HttpGet]
        public async Task<List<ChildDto>> Get()
        {
            return await _childServise.GetAllAsync();

        }


        [HttpGet("{id}")]
        public async Task<ChildDto> Get(string id)
        {
            return await _childServise.GetByIdAsync(id);

        }


        [HttpPost]
        public async Task<ChildDto> Post([FromBody] ChildPostModel child)
        {
            return await _childServise.AddAsync(new ChildDto{ Identity=child.Identity,ParentId=child.ParentId,BornDate = child.BornDate,Name = child.Name});
        }


        [HttpPut]
        public async Task<ChildDto> Put([FromBody] ChildDto cause)
        {
            return await _childServise.UpdateAsync(cause);
        }


        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _childServise.DeleteAsync(id);
        }
    }
}
