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
	public class TouristRegistration : ControllerBase
	{
		[HttpGet]
		[Route("gettouristregistration")]
		public async Task<ActionResult> GetTouristRegistration()
		{
			ContentResult result = new ContentResult();
			result = (ContentResult)await DalCRUD.ReadData("SP_GetTouristRegistration");
			if (result != null)
			{
				return result;
			}
			else { return new ContentResult(); }
		}


		[HttpPost]
		[Route("savetouristregistration")]
		public async Task SaveTouristRegistration(EntTouristRegistration etr)
		{
			SqlParameter[] sp =
			{
				new SqlParameter("@Name",etr.Name),
				new SqlParameter("@Mobile",etr.Mobile),
				 new SqlParameter("@Email",etr.Email),
				new SqlParameter("@Address",etr.Address),
			};
			await DalCRUD.CRUD("SP_SaveTouristRegistration", sp);
		}



		[HttpDelete]
		[Route("deletetouristregistration")]
		public async Task DeleteTouristRegistration(EntTouristRegistration etr)
		{
			SqlParameter[] sp =
			{
				new SqlParameter("@pk_RegId",etr.pk_RegId)
			};
			await DalCRUD.CRUD("SP_DeleteTouristRegistration", sp);
		}


		[HttpPut]
		[Route("updatetouristregistration")]
		public async Task UpdateTouristRegistration(EntTouristRegistration etr)
		{
			SqlParameter[] sp =
			{
				new SqlParameter("@pk_RegId",etr.pk_RegId),
				new SqlParameter("@Name",etr.Name),
				new SqlParameter("@Mobile",etr.Mobile),
				new SqlParameter("@Email",etr.Email),
				new SqlParameter("@Address",etr.Address),
			};
			await DalCRUD.CRUD("SP_UpdateTouristRegistration", sp);
		}






	}
}