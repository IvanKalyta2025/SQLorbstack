
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

    }
}