using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibraryEntity;
using ClassLibraryDAL;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;


namespace PkTripAPI.Controllers.TourGuideAdmin
{
    [Route("api/tourguide/")]
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
			result = (ContentResult)await DalCRUD.ReadData("SP_GetTourPackage",sp);
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
        [Route("deletetourpackage/{pkg_Id}")]
        public async Task Deletetourpackage(int pkg_Id)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@pk_PackageId",pkg_Id)
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