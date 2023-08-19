using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibraryEntity;
using ClassLibraryDAL;
using System.Xml.Linq;
using System.Data.SqlClient;


namespace PkTripAPI.Controllers.TourGuideAdmin
{
    [Route("api/tourguide/")]
    [ApiController]
    public class CompanyServicesController : ControllerBase
    {
        [HttpGet]
        [Route("getcompanyservices/{companyId}")]
        public async Task<ActionResult> GetTourCompanyServices(int companyId)
        {
            ContentResult result = new ContentResult();
			SqlParameter[] sp =
			{
				new SqlParameter("@pk_CompanyId",companyId)
			};
			result = (ContentResult)await DalCRUD.ReadData("SP_GetCompanyServices",sp);
            if (result != null)
            {
                return result;
            }
            else { return new ContentResult(); }
        }

        [HttpPost]
        [Route("savecompanyservices")]
		public async Task SaveCompanyServices(EntCompanyServices services)
		{
			SqlParameter[] sp ={
				new SqlParameter("@fk_CompanyId",services.fk_CompanyId),
				new SqlParameter("@ServicesDescription",services.ServicesDescription)
			};
			await DalCRUD.CRUD("SP_SaveCompanyServices", sp);
		}

		[HttpPut]
		[Route("updatecompanyservices")]
		public async Task UpdateCompanyServices(EntCompanyServices services)
		{
			SqlParameter[] sp ={
				new SqlParameter("@pk_CompanyServiceId",services.pk_CompanyServiceId),
				new SqlParameter("@fk_CompanyId",services.fk_CompanyId),
				new SqlParameter("@ServicesDescription",services.ServicesDescription)
			};
			await DalCRUD.CRUD("SP_UpdateCompanyServices", sp);
		}
	}
}