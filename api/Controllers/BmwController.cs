
using api.Data;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/bmw-model")]
    [ApiController]
    public class BmwController : ControllerBase
    {
        private readonly AppContextApplication _appContextApplication;

        public BmwController(AppContextApplication appContextApplication)
        {
            _appContextApplication = appContextApplication;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var bmwdetailofmodel = _appContextApplication.BmwM90Ordinary.ToList();
            return Ok(bmwdetailofmodel);
        }

    }
}