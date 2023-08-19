using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibraryEntity;
using ClassLibraryDAL;
using System.Data.SqlClient;

namespace PkTripAPI.Controllers.TourGuideAdmin
{
    [Route("api/tourguide/")]
    [ApiController]
    public class ServiceDetailsController
    {
        [HttpGet]
        [Route("getallservicedetails")]
        public async Task<ActionResult> GetAllServiceDetails()
        {
            ContentResult result = new ContentResult();
            result = (ContentResult)await DalCRUD.ReadData("SP_GetAllServiceDetails");
            if (result != null)
            {
                return result;
            }
            else { return new ContentResult(); }
        }

        [HttpGet]
        [Route("getservicedetails/{SubCatId}")]
        public async Task<ActionResult> GetServiceDetails(int SubCatId)
        {
            ContentResult result = new ContentResult();
            SqlParameter[] sp =
            {
            new SqlParameter("@pk_SubCategoryId",SubCatId)
            };
            result = (ContentResult)await DalCRUD.ReadData("SP_GetServiceDetails", sp);
            if (result != null)
            {
                return result;
            }
            else { return new ContentResult(); }
        }

    }
}
