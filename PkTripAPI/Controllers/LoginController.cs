using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibraryEntity;
using ClassLibraryDAL;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace PkTripAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpGet]
        [Route("getlogin")]
        public async Task<ActionResult> GetLogin()
        {
            ContentResult result = new ContentResult();
            result = (ContentResult)await DalCRUD.ReadData("SP_GetLogin");
            if (result != null)
            {
                return result;
            }
            else { return new ContentResult(); } //couldn't login if null
        }

    }
}