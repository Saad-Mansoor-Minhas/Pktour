using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibraryEntity;
using ClassLibraryDAL;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;


namespace PkTripAPI.Controllers.Admin
{
    [Route("api/")]
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


        [HttpPost]
        [Route("saveservicesubcategory")]
        public async Task SaveServiceSubCategory(EntServiceSubCategory essc)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@fk_CategoryId",essc.fk_CategoryId),
                new SqlParameter("@Title",essc.Title)
            };
            await DalCRUD.CRUD("SP_SaveServiceSubCategory", sp);
        }



        [HttpDelete]
        [Route("deleteservicesubcategory/{SubCatId}")]
        public async Task DeleteServiceSubCategory(int SubCatId)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@pk_SubCategoryId",SubCatId)
            };
            await DalCRUD.CRUD("SP_DeleteServiceSubCategory", sp);
        }


        [HttpPut]
        [Route("updateservicesubcategory")]
        public async Task UpdateServiceSubCategory(EntServiceSubCategory essc)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@pk_SubCategoryId",essc.pk_SubCategoryId),
                new SqlParameter("@fk_CategoryId",essc.fk_CategoryId),
                new SqlParameter("@Title",essc.Title)
            };
            await DalCRUD.CRUD("SP_UpdateServiceSubCategory", sp);
        }


    }
}