﻿using Microsoft.AspNetCore.Mvc;
using ClassLibraryEntity;
using ClassLibraryDAL;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace PkTripAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ViewpointsController : Controller
    {
        [HttpGet]
        [Route("getviewpoints")]
        public async Task<ActionResult> GetViewpoints()
        {
            ContentResult contentResult = new ContentResult();
            contentResult = (ContentResult)await DalCRUD.ReadData("SP_GetViewpoints");
            if (contentResult != null)
            {
                return contentResult;
            }
            else { return new ContentResult(); }
        }

		[HttpPost]
        [Route("saveviewpoint")]
        public void SaveViewpoint(EntViewpoints viewpoint)
        {
            SqlParameter[] sqlParameter =
            {
                new SqlParameter("@VpName",viewpoint.VpName),
            new SqlParameter("@VpDetailEng", viewpoint.VpDetailEng),
            new SqlParameter("@VpDetailUrdu", viewpoint.VpDetailUrdu),
            new SqlParameter("fk_CityId",viewpoint.fk_CityId)
            };
            DalCRUD.CRUD("SP_SaveViewpoint", sqlParameter);
        }

        [HttpPut]
        [Route("updateviewpoint")]
        public void UpdateViewpoint(EntViewpoints viewpoint)
        {
            SqlParameter[] sqlParameter =
           {
            new SqlParameter("@pk_ViewpointId",viewpoint.pk_ViewpointId),
            new SqlParameter("@VpName",viewpoint.VpName),
            new SqlParameter("@VpDetailEng", viewpoint.VpDetailEng),
            new SqlParameter("@VpDetailUrdu", viewpoint.VpDetailUrdu),
            new SqlParameter("fk_CityId",viewpoint.fk_CityId)
           };
            DalCRUD.CRUD("SP_UpdateViewpoint", sqlParameter);
        }

        [HttpDelete]
        [Route("deleteviewpoint/{pk_ViewpointId}")]
        public void DeleteViewpoint(int pk_ViewpointId)
        {
            SqlParameter[] sqlParameter = {
             new SqlParameter("@pk_ViewpointId", pk_ViewpointId)
            };
            DalCRUD.CRUD("SP_DeleteViewpoint", sqlParameter);
        }

    }
}