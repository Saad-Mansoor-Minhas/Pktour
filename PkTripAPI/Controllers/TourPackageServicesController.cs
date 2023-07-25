using ClassLibraryDAL;
using ClassLibraryEntity;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace PkTripAPI.Controllers
{
	[Route("api/")]
	[ApiController]
	public class TourPackageServicesController : Controller
	{
		[HttpGet]
		[Route("gettourpackageservices")]
		public async Task<ActionResult> GetTourPackageServices()
		{
			ContentResult result = new ContentResult();
			result = (ContentResult)await DalCRUD.ReadData("SP_GetTourPackageServices");
			if (result != null)
			{
				return result;
			}
			else { return new ContentResult(); }
		}


		[HttpPost]
		[Route("savetourpackageservices")]
		public async Task SaveTourPackageServices(EntTourPackageServices etps)
		{
			SqlParameter[] sp =
			{
				new SqlParameter("@fk_CompanyServiceId",etps.fk_CompanyServiceId),
			};
			await DalCRUD.CRUD("SP_SaveTourPackageService", sp);
		}



		[HttpPut]
		[Route("updatetourpackageservices")]
		public async Task UpdateTourPackageServices(EntTourPackageServices etps)
		{
			SqlParameter[] sp =
			{
				new SqlParameter("@pk_PkgServiceId", etps.pk_PkgServiceId),
				new SqlParameter("@fk_CompanyServiceId",etps.fk_CompanyServiceId),
			};
			await DalCRUD.CRUD("SP_UpdateTourPackageService", sp);//==>*
		}



		[HttpDelete]
		[Route("deletetourpackageservices")]
		public async Task DeleteTourPackageServices(EntTourPackageServices etps)
		{
			SqlParameter[] sp =
			{
				new SqlParameter("@pk_PkgServiceId",etps.pk_PkgServiceId),
			};
			await DalCRUD.CRUD("SP_DeleteTourPackageService", sp);//==>*
		}
	}
}
