using Business.Repositories.TableRepository;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TablesController : ControllerBase
    {
        private readonly ITableService _tableService;

        public TablesController(ITableService tableService)
        {
            _tableService = tableService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult>Add(Table table)
        {
            var result = await _tableService.Add(table);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(Table table)
        {
            var result = await _tableService.Update(table);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(Table table)
        {
            var result = await _tableService.Delete(table);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _tableService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _tableService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
