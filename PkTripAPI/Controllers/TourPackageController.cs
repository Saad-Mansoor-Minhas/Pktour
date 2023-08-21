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
	public class TourPackageController : ControllerBase
	{
		[HttpGet]
		[Route("gettourpackage/{companyId}")]
		public async Task<ActionResult> GetTourPackage(int companyId)
		{
			ContentResult result = new ContentResult();
			SqlParameter[] sp =
			{
				new SqlParameter("@pk_CompanyId",companyId)
			};
			result = (ContentResult)await DalCRUD.ReadData("SP_GetTourPackage", sp);
			if (result != null)
			{
				return result;
			}
			else { return new ContentResult(); }
		}

		[HttpPost]
		[Route("savetourpackage")]
		public async Task SaveTourPackage(EntTourPackage etp)
		{
			SqlParameter[] sp =
			{
				new SqlParameter("@fk_CompanyId",etp.fk_CompanyId),
				new SqlParameter("@Title",etp.Title),
				new SqlParameter("@Duration",etp.Duration),
				new SqlParameter("@Pricing",etp.Pricing),
				new SqlParameter("@FromCity",etp.FromCity),
				new SqlParameter("@ToCity",etp.ToCity),
			};
			await DalCRUD.CRUD("SP_SaveTourPackage", sp);
		}


		[HttpDelete]
		[Route("deletetourpackage")]
		public async Task Deletetourpackage(EntTourPackage etp)
		{
			SqlParameter[] sp =
			{
				new SqlParameter("@pk_PackageId",etp.pk_PackageId)
			};
			await DalCRUD.CRUD("SP_DeleteTourPackage", sp);
		}

		[HttpPut]
		[Route("updatetourpackage")]
		public async Task UpdateTourPackage(EntTourPackage etp)
		{
			SqlParameter[] sp =
			{

				new SqlParameter("@pk_PackageId",etp.pk_PackageId),
				new SqlParameter("@fk_CompanyId",etp.fk_CompanyId),
				new SqlParameter("@Title",etp.Title),
				new SqlParameter("@Duration",etp.Duration),
				new SqlParameter("@Pricing",etp.Pricing),
				new SqlParameter("@FromCity",etp.FromCity),
				new SqlParameter("@ToCity",etp.ToCity)
			};
			await DalCRUD.CRUD("SP_UpdateTourPackage", sp);
		}
	}


}