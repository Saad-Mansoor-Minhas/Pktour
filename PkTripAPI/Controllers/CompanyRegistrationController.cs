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

	public class CompanyRegistrationController : ControllerBase
	{
		[HttpGet]
		[Route("getcompanyregistration")]
		public async Task<ActionResult> GetCompanyRegistration()
		{
			ContentResult result = new ContentResult();
			result = (ContentResult)await DalCRUD.ReadData("SP_GetCompanyRegistration");
			if (result != null)
			{
				return result;
			}
			else { return new ContentResult(); }
		}

		[HttpPost]
		[Route("savecompanyregistration")]
		public async Task SaveCompanyRegistration(EntCompanyRegistration obj)
		{
			SqlParameter[] sp =
			{

			new SqlParameter("@RegDate",obj.RegDate),
			new SqlParameter("@fk_TourGuideId",obj.fk_TourGuideId),
			new SqlParameter("@Name",obj.Name),
			new SqlParameter("@Instagram",obj.Instagram),
			new SqlParameter("@Facebook",obj.Facebook),
			new SqlParameter("@RegStatus",obj.RegStatus),
			new SqlParameter("@RegTime",obj.RegTime),
			new SqlParameter("@Sector",obj.fk_AreaId),
			new SqlParameter("@Website",obj.Website)

			};

			await DalCRUD.CRUD("SP_SaveCompanyRegistration", sp);
		}

		[HttpDelete]
		[Route("deletecompanyregistration")]
		public async Task DeleteCompanyRegistration(int pk_CompanyId)
		{
			SqlParameter[] sp =
			{
				new SqlParameter("@pk_CompanyId",pk_CompanyId)
			};
			await DalCRUD.CRUD("SP_DeleteCompanyRegistration", sp);
		}

		[HttpPost]
		[Route("updatecompanyregistration")]
		public async Task UpdateCompanyRegistration(EntCompanyRegistration obj)
		{
			SqlParameter[] sp =
			{
				new SqlParameter("@pk_CompanyId",obj.pk_CompanyId),
				new SqlParameter("@RegDate",obj.RegDate),
				new SqlParameter("@fk_TourGuideId",obj.fk_TourGuideId),
				new SqlParameter("@Name",obj.Name),
				new SqlParameter("@CompanyAddress", obj.Address),
				new SqlParameter("@CompanyAddress", obj.Address),
				new SqlParameter("@Instagram",obj.Instagram),
				new SqlParameter("@Facebook",obj.Facebook),
				new SqlParameter("@RegStatus",obj.RegStatus),
				new SqlParameter("@RegTime",obj.RegTime),
				new SqlParameter("@Sector",obj.fk_AreaId),
				new SqlParameter("@Website",obj.Website)
			};
			await DalCRUD.CRUD("SP_UpdateCompanyRegistration", sp);
		}


	}

}
