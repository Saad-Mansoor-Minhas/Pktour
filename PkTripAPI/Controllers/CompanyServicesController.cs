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
    public class CompanyServicesController : ControllerBase
    {
        [HttpGet]
        [Route("getcompanyservices")]
        public async Task<ActionResult> GetTourCompanyServices()
        {
            ContentResult result = new ContentResult();
            result = (ContentResult)await DalCRUD.ReadData("SP_GetCompanyServices");
            if (result != null)
            {
                return result;
            }
            else { return new ContentResult(); }

        }
    }
}