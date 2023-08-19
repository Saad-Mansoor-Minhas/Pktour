using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibraryEntity;
using ClassLibraryDAL;
using System.Data;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace PkTripAPI.Controllers.Admin
{
    [Route("api/")]
    [ApiController]
    public class ServiceCategoryController
    {

        [HttpGet]
        [Route("getservicecategory")]
        public async Task<ActionResult> GetServiceCategory()
        {
            ContentResult result = new ContentResult();
            result = (ContentResult)await DalCRUD.ReadData("SP_GetServiceCategory");
            if (result != null)
            {
                return result;
            }
            else { return new ContentResult(); }  //return null or return new contentresult is same becase new content has null 
        }



        [HttpPost]
        [Route("saveservicecategory")]
        public async Task SaveServiceCategory(EntServiceCategory esc)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@Title",esc.Title),
                new SqlParameter("@Type",esc.Type),
            };
            await DalCRUD.CRUD("SP_SaveServiceCategory", sp);
        }



        [HttpDelete]
        [Route("deleteservicecategory/{ServiceId}")]
        public async Task DeleteServiceCategory(int ServiceId)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@pk_CategoryId",ServiceId)
            };
            await DalCRUD.CRUD("SP_DeleteServiceCategory", sp);
        }


        [HttpPut]
        [Route("updateservicecategory")]
        public async Task UpdateServiceCategory(EntServiceCategory esc)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@pk_CategoryId",esc.pk_CategoryId),
                new SqlParameter("@Title",esc.Title),
                new SqlParameter("@Type",esc.Type),
            };
            await DalCRUD.CRUD("SP_UpdateServiceCategory", sp);
        }

    }
}