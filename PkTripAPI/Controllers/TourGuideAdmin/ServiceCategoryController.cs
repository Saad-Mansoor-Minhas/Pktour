﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibraryEntity;
using ClassLibraryDAL;
using System.Data;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace PkTripAPI.Controllers.TourGuideAdmin
{
    [Route("api/tourguide/")]
    [ApiController]
    public class ServiceCategoryController
    {

        [HttpGet]
        [Route("getservicecategory")]
        public async Task<ActionResult> GetServiceCategory()
        {
            ContentResult result = new ContentResult();
            result = (ContentResult)await DalCRUD.ReadData("SP_GetServiceCategory");
            if (result != null)
            {
                return result;
            }
            else { return new ContentResult(); }  //return null or return new contentresult is same becase new content has null 
        }
    }
}