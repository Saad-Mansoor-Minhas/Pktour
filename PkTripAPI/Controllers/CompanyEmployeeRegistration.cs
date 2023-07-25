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

	public class CompanyEmployeeRegistrationController : ControllerBase
	{
		[HttpGet]
		[Route("getcompanyemployeeregistration")]
		public async Task<ActionResult> CompanyEmployeeRegistration()
		{
			ContentResult result = new ContentResult();
			result = (ContentResult)await DalCRUD.ReadData("SP_GetCompanyEmployeeRegistration");
		
			if (result != null)
			{
				return result;
			}
			else
			{ 

			return new ContentResult();
			
			}
		}

		[HttpPost]
		[Route("savecompanyemployeeregistration")]
		public async Task SaveCompanyEmployeeRegistration(EntCompanyEmployeeRegistration obj)
		{
			SqlParameter[] sp =
			{
				new SqlParameter("@DOB",obj.DOB),
				new SqlParameter("@RegDate",obj.RegDate),
				new SqlParameter("@Role",obj.Role),
				new SqlParameter("@Gender",obj.Gender),
				new SqlParameter("@RegTime",obj.RegTime),
				new SqlParameter("@RegStatus",obj.RegStatus),
				new SqlParameter("@fk_CityId",obj.fk_CityId),
				new SqlParameter("@fk_CompanyId",obj.fk_CompanyId),
				new SqlParameter("@FirstName",obj.FirstName),
				new SqlParameter("@LastName",obj.LastName),
				new SqlParameter("@CNIC",obj.CNIC),
				new SqlParameter("@Mobile",obj.Mobile),
				new SqlParameter("@WhatsappNum",obj.WhatsappNum),
				new SqlParameter("@Sector",obj.Sector)


			};

			await DalCRUD.CRUD("SP_SaveCompanyEmployeeRegistration", sp);
		}

		[HttpDelete]
		[Route("deletecompanyemployeeregistration")]
		public async Task DeleteCompanyEmployeeRegistration(int pk_CompanyMemberId)
		{
			SqlParameter[] sp =
			{
				new SqlParameter("@pk_CompanyMemberId",pk_CompanyMemberId)
			};

			await DalCRUD.CRUD("SP_DeleteCompanyEmployeeRegistration", sp);
		}

		[HttpPost]
		[Route("updatecompanyemployeeregistration")]
		public async Task UpdateCompanyEmployeeRegistration(EntCompanyEmployeeRegistration obj)
		{
			SqlParameter[] sp =
			{
				new SqlParameter("@pk_CompanyMemberId",obj.pk_CompanyMemberId),
				new SqlParameter("@DOB",obj.DOB),
				new SqlParameter("@RegDate",obj.RegDate),
				new SqlParameter("@Role",obj.Role),
				new SqlParameter("@Gender",obj.Gender),
				new SqlParameter("@RegTime",obj.RegTime),
				new SqlParameter("@RegStatus",obj.RegStatus),
				new SqlParameter("@fk_CityId",obj.fk_CityId),
				new SqlParameter("@fk_CompanyId",obj.fk_CompanyId),
				new SqlParameter("@FirstName",obj.FirstName),
				new SqlParameter("@LastName",obj.LastName),
				new SqlParameter("@CNIC",obj.CNIC),
				new SqlParameter("@Mobile",obj.Mobile),
				new SqlParameter("@WhatsappNum",obj.WhatsappNum),
				new SqlParameter("@Sector",obj.Sector)


			};

			await DalCRUD.CRUD("SP_UpdateCompanyEmployeeRegistration", sp);
		}



	}
}
	