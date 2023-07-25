using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibraryEntity;
using ClassLibraryDAL;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;


namespace PkTripAPI.Controllers
{
	[Route("api/")]
	[ApiController]
	public class ServiceSubCategoryController : ControllerBase
	{
		[HttpGet]
		[Route("getservicesubcategory")]
		public async Task<ActionResult> GetServiceSubCategory()
		{
			ContentResult result = new ContentResult();
			result = (ContentResult)await DalCRUD.ReadData("SP_GetServiceSubCategory");
			if (result != null)
			{
				return result;
			}
			else { return new ContentResult(); }
		}


		[HttpPost]
		[Route("saveservicesubcatagory")]
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
		[Route("deleteservicesubcatagory")]
		public async Task DeleteServiceSubCategory(EntServiceSubCategory essc)
		{
			SqlParameter[] sp =
			{
				new SqlParameter("@pk_SubCategoryId",essc.pk_SubCategoryId)
			};
			await DalCRUD.CRUD("SP_DeleteServiceSubCategory", sp);
		}


		[HttpPut]
		[Route("updateservicesubcatagory")]
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