using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibraryEntity;
using ClassLibraryDAL;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;
using System.Web.Helpers;


namespace PkTripAPI.Controllers
{
	[Route("api/")]
	[ApiController]
	public class TourGuideRegistrationController : ControllerBase
	{
		[HttpGet]
		[Route("gettourguidesinfo")]
		public async Task<ActionResult> GetTourGuideRegistration()
		{
			ContentResult result = new ContentResult();
			result = (ContentResult)await DalCRUD.ReadData("SP_GetTourGuidesInfo");
			if (result != null)
			{
				return result;
			}
			else { return new ContentResult(); }
		}


		[HttpPost]
		[Route("registertourguide")]
		public async Task SaveTourGuideRegistration(RegistrationModel registration)
		{
			SqlParameter[] sp =
			{
                new SqlParameter("@fk_CityId",registration.TourGuide.fk_CityId),
				new SqlParameter("@FullName",registration.TourGuide.Name),
				new SqlParameter("@Email",registration.TourGuide.Email),
				new SqlParameter("@CompanyName",registration.TourGuideCompany.Name),
				new SqlParameter("@CompanySector",registration.TourGuideCompany.Sector),
				//new SqlParameter("@DOB",etgr.DOB.ToString()),
				//new SqlParameter("@RegDate",etgr.RegDate),
				//new SqlParameter("@RegTime",etgr.RegTime),
				//new SqlParameter("@RegStatus",etgr.RegStatus)
			};
			await DalCRUD.CRUD("SP_TourGuideRegistration", sp);
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
				new SqlParameter("@RegDate",etgr.RegDate),
				new SqlParameter("@RegTime",etgr.RegTime),
				new SqlParameter("@RegStatus",etgr.RegStatus)
			};
			await DalCRUD.CRUD("SP_UpdateTourGuideRegistration", sp);
		}

	}

}