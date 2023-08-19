using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibraryEntity;
using ClassLibraryDAL;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;


namespace PkTripAPI.Controllers.TourGuideAdmin
{
    [Route("api/tourguide/")]
    [ApiController]
    public class ServiceSubCategoryController : ControllerBase
    {
        [HttpGet]
        [Route("getallservicesubcategory")]
        public async Task<ActionResult> GetAllServiceSubCategory()
        {
            ContentResult result = new ContentResult();
            result = (ContentResult)await DalCRUD.ReadData("SP_GetAllServiceSubCategory");
            if (result != null)
            {
                return result;
            }
            else { return new ContentResult(); }
        }

        [HttpGet]
        [Route("getservicesubcategory/{CatId}")]
        public async Task<ActionResult> GetServiceSubCategory(int CatId)
        {
            ContentResult result = new ContentResult();
            SqlParameter[] sp =
            {
                new SqlParameter("@pk_CategoryId",CatId)
            };
            result = (ContentResult)await DalCRUD.ReadData("SP_GetServiceSubCategory", sp);
            if (result != null)
            {
                return result;
            }
            else { return new ContentResult(); }
        }
    }
}