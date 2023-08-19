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
    public class AreaController : ControllerBase
    {
        [HttpGet]
        [Route("getareas")]
        public async Task<ActionResult> GetAreas()
        {
            ContentResult result = new ContentResult();
            result = (ContentResult)await DalCRUD.ReadData("SP_GetAreas");
            if (result != null)
            {
                return result;
            }
            else { return new ContentResult(); }
        }


        [HttpGet]
        [Route("getcityareas/{cityId}")]
        public async Task<ActionResult> GetAreaByCity(int cityId)
        {
            ContentResult result = new ContentResult();
            SqlParameter[] sp =
            {
                    new SqlParameter("@pk_CityId",cityId),
                };
            result = (ContentResult)await DalCRUD.ReadData("SP_GetAreasByCity", sp);
            if (result != null)
            {
                return result;
            }
            else { return new ContentResult(); }
        }


        [HttpPost]
        [Route("savearea")]
        public async Task SaveArea(EntAreas area)
        {

            SqlParameter[] sp =
            {
                    new SqlParameter("@fk_CityId",area.fk_CityId),
                    new SqlParameter("@AreaName",area.AreaName)
                };
            await DalCRUD.CRUD("SP_SaveArea", sp);
        }

        [HttpDelete]
        [Route("deletecity/{areaId}")]
        public async Task DeleteArea(int areaId)
        {
            SqlParameter[] sp =
            {
                    new SqlParameter("@pk_AreaId",areaId)
                };
            await DalCRUD.CRUD("SP_DeleteArea", sp);
        }

        [HttpPut]
        [Route("updatearea")]
        public async Task UpdateArea(EntAreas area)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@pk_AreaId",area.pk_AreaId),
                new SqlParameter("@fk_CityId",area.fk_CityId),
                new SqlParameter("@AreaName",area.AreaName)
            };
            await DalCRUD.CRUD("SP_UpdateArea", sp);
        }
    }
}
