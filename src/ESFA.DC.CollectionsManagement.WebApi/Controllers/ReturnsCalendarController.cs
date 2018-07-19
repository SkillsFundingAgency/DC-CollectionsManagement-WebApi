using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESFA.DC.CollectionsManagement.Models;
using ESFA.DC.CollectionsManagement.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ESFA.DC.CollectionsManagement.WebApi.Controllers
{
    [Route("api/returns-calendar")]
    public class ReturnsCalendarController : Controller
    {
        private readonly IReturnCalendarService _retrunCalendarService;

        public ReturnsCalendarController(IReturnCalendarService retrunCalendarService)
        {
            _retrunCalendarService = retrunCalendarService;
        }

        // GET api/values/5
        [HttpGet("{collectionName}")]
        public ReturnPeriod Get(string collectionName)
        {
            return _retrunCalendarService.GetCurrentPeriod(collectionName);
        }
    }
}