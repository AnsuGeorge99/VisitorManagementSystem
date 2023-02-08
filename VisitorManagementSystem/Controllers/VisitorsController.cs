using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VisitorManagementSystem.BusinessLogic;
using VisitorManagementSystem.Models.VisitorForm;

namespace VisitorManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorsController : ControllerBase
    {
        private readonly IVisitorsBL _visitor;
        public VisitorsController(IVisitorsBL visitorBL)
        {
            _visitor = visitorBL;
        }

        [HttpGet("GetAllVistors")]
        public async Task<IActionResult> GetAllVistors()
        {
            try
            {
                var list = await _visitor.GetAllVisitor();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddVisitor")]
        public async Task<IActionResult> AddVisitor(Visitor visitor)
        {
            try
            {
                await _visitor.AddVisitor(visitor);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
