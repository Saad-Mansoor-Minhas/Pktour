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

	public class CompanyContactsController : ControllerBase
	{
		[HttpGet]
		[Route("getcompanycontacts")]
		public async Task<ActionResult> GetCompanyContacts()
		{
			ContentResult result = new ContentResult();
			result = (ContentResult)await DalCRUD.ReadData("SP_GetCompanyContacts");
			if (result != null)
			{
				return result;
			}
			else { return new ContentResult(); }
		}

		[HttpPost]
		[Route("savecompanycontact")]

		public async Task SaveCompanyContact(EntCompanyContacts obj)
		{
			SqlParameter[] sp =
			{

			new SqlParameter("@fk_CompanyId",obj.fk_CompanyId),
			new SqlParameter("@ContactType",obj.ContactType),
			new SqlParameter("@ContactNum",obj.ContactNum),

			};

			await DalCRUD.CRUD("SP_SaveCompanyContacts", sp);
		}

		[HttpDelete]
		[Route("deletecompanycontact")]
		public async Task DeleteCompanyContact(EntCompanyContacts obj)
		{
			SqlParameter[] sp =
			{
				new SqlParameter("@pk_CompanyContactId",obj.pk_CompanyContactId)
			};
			await DalCRUD.CRUD("SP_DeleteCompanyContact", sp);
		}

		[HttpPut]
		[Route("updatecompanycontact")]
		public async Task UpdateCompanyContact(EntCompanyContacts obj)
		{
			SqlParameter[] sp =
			{
				new SqlParameter("@pk_CompanyContactId",obj.pk_CompanyContactId),
				new SqlParameter("@fk_CompanyId",obj.fk_CompanyId),
				new SqlParameter("@ContactType",obj.ContactType),
				new SqlParameter("@ContactNum",obj.ContactNum)
			};
			await DalCRUD.CRUD("SP_UpdateCompanyContacts", sp);
		}
	}

}
