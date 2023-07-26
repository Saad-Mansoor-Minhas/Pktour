using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibraryEntity;
using ClassLibraryDAL;
using System.Data.SqlClient;

namespace PkTripAPI.Controllers
{
    [Route("api/")]
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
			result = (ContentResult)await DalCRUD.ReadData("SP_GetServiceDetails",sp);
			if (result != null)
			{
				return result;
			}
			else { return new ContentResult(); }
		}

		[HttpPost]
        [Route("saveservicedetail")]
        public async Task SaveServiceDetails(EntServiceDetails obj)
        {
            SqlParameter[] sp =
            {

                new SqlParameter("@fk_CategoryId",obj.fk_CategoryId),
                new SqlParameter("@fk_SubCategoryId",obj.fk_SubCategoryId),
            new SqlParameter("@Unit",obj.Unit),
            new SqlParameter("@Title",obj.Title),
            new SqlParameter("@Quantity",obj.Quantity),
            new SqlParameter("@Price",obj.Price)

            };

            await DalCRUD.CRUD("SP_SaveServiceDetail", sp);
        }

        [HttpDelete]
        [Route("deleteservicedetail/{ServDetId}")]
        public async Task DeleteServiceDetails(int ServDetId)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@pk_ServiceDetailId",ServDetId)
            };
            await DalCRUD.CRUD("SP_DeleteServiceDetail", sp);
        }

        [HttpPut]
        [Route("updateservicedetail")]
        public async Task UpdateServiceDetails(EntServiceDetails obj)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@pk_ServiceDetailId",obj.pk_ServiceDetailId),
                new SqlParameter("@fk_CategoryId",obj.fk_CategoryId),
                new SqlParameter("@fk_SubCategoryId",obj.fk_SubCategoryId),
                new SqlParameter("@Unit",obj.Unit),
                new SqlParameter("@Title",obj.Title),
                new SqlParameter("@Quantity",obj.Quantity),
                new SqlParameter("@Price",obj.Price)
            };
            await DalCRUD.CRUD("SP_UpdateServiceDetail", sp);
        }

    }
}
