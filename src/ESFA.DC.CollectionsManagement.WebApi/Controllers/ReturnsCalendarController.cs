using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESFA.DC.CollectionsManagement.Interfaces;
using ESFA.DC.CollectionsManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace ESFA.DC.CollectionsManagement.WebApi.Controllers
{
    [Route("api/returns-calendar")]
    public class ReturnsCalendarController : Controller
    {
        private readonly IRetrunCalendarService _retrunCalendarService;

        public ReturnsCalendarController(IRetrunCalendarService retrunCalendarService)
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