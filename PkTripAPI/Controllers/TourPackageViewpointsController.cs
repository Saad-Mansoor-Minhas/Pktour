using ClassLibraryDAL;
using ClassLibraryEntity;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace PkTripAPI.Controllers
{
	[Route("api/")]
	[ApiController]
	public class TourPackageViewpointsController : Controller
	{
		[HttpGet]
		[Route("gettourpackageviewpoints")]
		public async Task<ActionResult> GetTourPackageViewpoints()
		{
			ContentResult result = new ContentResult();
			result = (ContentResult)await DalCRUD.ReadData("SP_GetTourPackageViewpoints");
			if (result != null)
			{
				return result;
			}
			else { return new ContentResult(); }
		}


		[HttpPost]
		[Route("savetourpackageviewpoints")]
		public async Task SaveTourPackageViewpoints(EntTourPackageViewpoints etpv)
		{
			SqlParameter[] sp =
			{
				new SqlParameter("@fk_ViewpointId",etpv.fk_ViewpointId),
			};
			await DalCRUD.CRUD("SP_SaveTourPackageViewpoints", sp);         //==>*
		}



		[HttpPut]
		[Route("updatetourpackageviewpoints")]
		public async Task UpdateTourPackageViewpoints(EntTourPackageViewpoints etpv)
		{
			SqlParameter[] sp =
			{
				new SqlParameter("@pk_PkgViewpointId",etpv.pk_PkgViewpointId),
				new SqlParameter("@fk_ViewpointId",etpv.fk_ViewpointId),
			};
			await DalCRUD.CRUD("SP_UpdateTourPackageViewpoints", sp);//==>*
		}



		[HttpDelete]
		[Route("deletetourpackageviewpoints")]
		public async Task DeleteTourPackageViewpoints(EntTourPackageViewpoints etpv)
		{
			SqlParameter[] sp =
			{
				new SqlParameter("@pk_PkgViewpointId",etpv.pk_PkgViewpointId),
			};
			await DalCRUD.CRUD("SP_DeleteTourPackageViewpoints", sp);//==>*
		}
	}
}
