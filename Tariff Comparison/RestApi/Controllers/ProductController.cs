using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.ServiceIntefaces;
using Domain.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IComparationService _comparationService;

        public ProductController(IComparationService comparationService)
        {
            _comparationService = comparationService;
        }

        [HttpGet]
        [Route("GetComparationDemo")]
        public IActionResult GetComparation()
        {
            try
            {
                List<ProductUsage> comparationResult = _comparationService.GetComparation(4500);

                return Ok(comparationResult);
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHelper.ErrorResponse(ex.Message));
            }
        }

        [HttpGet]
        [Route("GetComparationByConsumption")]
        public IActionResult GetComparationByConsumption([FromQuery]decimal consumption)
        {
            try
            {
                List<ProductUsage> comparationResult = _comparationService.GetComparation(consumption);

                return Ok(comparationResult);
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHelper.ErrorResponse(ex.Message));
            }
        }
    }
}