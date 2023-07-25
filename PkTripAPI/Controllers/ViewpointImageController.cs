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
    public class ViewpointImageController : ControllerBase
    {
        [HttpGet]
        [Route("getviewpointimage")]
        public async Task<ActionResult> GetViewPointImage()
        {
            ContentResult result = new ContentResult();
            result = (ContentResult)await DalCRUD.ReadData("SP_GetViewpointsImage");
            if (result != null)
            {
                return result;
            }
            else { return new ContentResult(); }

        }
    }
}
