using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibraryEntity;
using ClassLibraryDAL;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;

namespace PkTripAPI.Controllers.TourGuideAdmin
{
    [Route("api/tourguide/")]
    [ApiController]
    public class CompanyRegistrationController : ControllerBase
    {
        [HttpGet]
        [Route("getcompanyregistration")]
        public async Task<ActionResult> GetCompanyRegistration()
        {
            ContentResult result = new ContentResult();
            result = (ContentResult)await DalCRUD.ReadData("SP_GetRegisteredCompanies");
            if (result != null)
            {
                return result;
            }
            else { return new ContentResult(); }
        }

        [HttpGet]
        [Route("gettourguidecompanies/{tgId}")]
        public async Task<ActionResult> GetCompanyRegistration(int tgId)
        {
            ContentResult result = new ContentResult();
            SqlParameter[] sp =
            {
                new SqlParameter("@pk_TourGuideId",tgId)
            };
            result = (ContentResult)await DalCRUD.ReadData("SP_GetTourGuideCompanies", sp);
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
            SqlParameter[] sp ={
                new SqlParameter("@fk_TourGuideId",obj.fk_TourGuideId),
                new SqlParameter("@Name",obj.Name),
                new SqlParameter("@Email",obj.Email),
                new SqlParameter("@fk_CityId",obj.fk_CityId),
                new SqlParameter("@fk_AreaId",obj.fk_AreaId),
                new SqlParameter("@Address",obj.Address),
                new SqlParameter("@Website",obj.Website),
                new SqlParameter("@Facebook",obj.Facebook),
                new SqlParameter("@Instagram",obj.Instagram)
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
                new SqlParameter("@fk_TourGuideId",obj.fk_TourGuideId),
                new SqlParameter("@Name",obj.Name),
                new SqlParameter("@Email",obj.Email),
                new SqlParameter("@fk_CityId",obj.fk_CityId),
                new SqlParameter("@fk_AreaId",obj.fk_AreaId),
                new SqlParameter("@Address",obj.Address),
                new SqlParameter("@Website",obj.Website),
                new SqlParameter("@Facebook",obj.Facebook),
                new SqlParameter("@Instagram",obj.Instagram)
            };
            await DalCRUD.CRUD("SP_UpdateCompanyRegistration", sp);
        }


    }

}
