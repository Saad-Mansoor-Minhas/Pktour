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
	public class TourGuideRegistrationController : ControllerBase
	{
		[HttpGet]
		[Route("gettourguideregistration")]
		public async Task<ActionResult> GetTourGuideRegistration()
		{
			ContentResult result = new ContentResult();
			result = (ContentResult)await DalCRUD.ReadData("SP_GetTourGuideRegistration");
			if (result != null)
			{
				return result;
			}
			else { return new ContentResult(); }
		}


		[HttpPost]
		[Route("savetourguideregistration")]
		public async Task SaveTourGuideRegistration(EntTourGuideRegistration etgr)
		{
			SqlParameter[] sp =
			{
				new SqlParameter("@fk_CityId",etgr.fk_CityId),
				new SqlParameter("@Name",etgr.Name),
				new SqlParameter("@CNIC",etgr.CNIC),
				new SqlParameter("@DOB",etgr.DOB),
				new SqlParameter("@Gender",etgr.Gender),
				new SqlParameter("@Sector",etgr.Sector),
				new SqlParameter("@Name",etgr.Name),
				new SqlParameter("@CNIC",etgr.CNIC),
				new SqlParameter("@DOB",etgr.DOB),
				new SqlParameter("@Gender",etgr.Gender),
				new SqlParameter("@Sector",etgr.Sector)
			};
			await DalCRUD.CRUD("SP_SaveTourGuideRegistration", sp);
		}



		[HttpDelete]
		[Route("deletetourguideregistration")]
		public async Task DeleteTourGuideRegistration(EntTourGuideRegistration etgr)
		{
			SqlParameter[] sp =
			{
				new SqlParameter("@pk_TourGuideId",etgr.pk_TourGuideId)
			};
			await DalCRUD.CRUD("SP_DeleteTourGuideRegistration", sp);
		}


		[HttpPut]
		[Route("updatetourguideregistration")]
		public async Task UpdateTourGuideRegistration(EntTourGuideRegistration etgr)
		{
			SqlParameter[] sp =
			{

				new SqlParameter("@pk_TourGuideId",etgr.pk_TourGuideId),
				new SqlParameter("@fk_CityId",etgr.fk_CityId),
				new SqlParameter("@Name",etgr.Name),
				new SqlParameter("@CNIC",etgr.CNIC),
				new SqlParameter("@DOB",etgr.DOB),
				new SqlParameter("@Gender",etgr.Gender),
				new SqlParameter("@Sector",etgr.Sector),
				new SqlParameter("@Name",etgr.Name),
				new SqlParameter("@CNIC",etgr.CNIC),
				new SqlParameter("@DOB",etgr.DOB),
				new SqlParameter("@Gender",etgr.Gender),
				new SqlParameter("@Sector",etgr.Sector)
			};
			await DalCRUD.CRUD("SP_UpdateTourGuideRegistration", sp);
		}






	}
}