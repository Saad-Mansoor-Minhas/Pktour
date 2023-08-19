using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibraryEntity;
using ClassLibraryDAL;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;


namespace PkTripAPI.Controllers.Admin
{
    [Route("api/")]
    [ApiController]
    public class CityController : ControllerBase
    {
        [HttpGet]
        [Route("getcities")]
        public async Task<ActionResult> GetCities()
        {
            ContentResult result = new ContentResult();
            result = (ContentResult)await DalCRUD.ReadData("SP_GetCities");
            if (result != null)
            {
                return result;
            }
            else { return new ContentResult(); }
        }
        [HttpGet]
        [Route("getcity/{pk_CityId}")]
        public async Task<ActionResult> GetSpecificCity(int pk_CityId)
        {
            ContentResult result = new ContentResult();
            SqlParameter[] sp =
            {
                new SqlParameter("@pk_CityId",pk_CityId),
            };
            result = (ContentResult)await DalCRUD.ReadData("SP_GetSpecificCity", sp);
            if (result != null)
            {
                return result;
            }
            else { return new ContentResult(); }
        }


        [HttpPost]
        [Route("savecity")]
        public async Task SaveCity(EntCities ec)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@CityCode",ec.CityCode),
                new SqlParameter("@CityName",ec.CityName)
            };
            await DalCRUD.CRUD("SP_SaveCity", sp);
        }

        [HttpDelete]
        [Route("deletecity/{CityCode}")]
        public async Task DeleteCity(int CityCode)
        {

            SqlParameter[] sp =
            {
                new SqlParameter("@CityCode",CityCode)
            };
            await DalCRUD.CRUD("SP_DeleteCity", sp);
        }

        [HttpPut]
        [Route("updatecity")]
        public async Task UpdateCity(EntCities ec)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@pk_CityId",ec.pk_CityId),
                new SqlParameter("@CityCode",ec.CityCode),
                new SqlParameter("@CityName",ec.CityName)
            };
            await DalCRUD.CRUD("SP_UpdateCity", sp);
        }

    }


}