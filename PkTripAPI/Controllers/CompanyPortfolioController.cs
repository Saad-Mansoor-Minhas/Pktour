using System;
using Microsoft.AspNetCore.Mvc;
using ClassLibraryEntity;
using ClassLibraryDAL;
using Microsoft.AspNetCore.Http;


namespace PkTripAPI.Controllers
{
    [Route("api/")]
    [ApiController]

    public class CompanyPortfolioController
    {
        [HttpGet]
        [Route("getcompanyportfolio")]
        public async Task<ActionResult> GetCompanyPortfolio()
        {
            ContentResult result = new ContentResult();
            result = (ContentResult)await DalCRUD.ReadData("SP_GetCompanyPortfolio");
            if (result != null)
            {
                return result;
            }
            else { return new ContentResult(); }
        }
    }
}
