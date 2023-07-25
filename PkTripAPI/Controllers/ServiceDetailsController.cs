using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibraryEntity;
using ClassLibraryDAL;

namespace PkTripAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ServiceDetailsController
    {
        [HttpGet]
        [Route("getservicedetails")]
        public async Task<ActionResult> GetServiceDetails()
        {
            ContentResult result = new ContentResult();
            result = (ContentResult)await DalCRUD.ReadData("SP_GetServiceDetails");
            if (result != null)
            {
                return result;
            }
            else { return new ContentResult(); }  
        }

    }
}
