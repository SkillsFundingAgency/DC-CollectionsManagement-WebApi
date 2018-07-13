using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESFA.DC.CollectionsManagement.Models;
using ESFA.DC.CollectionsManagement.Service;
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
        [HttpGet("{type}")]
        public IEnumerable<ReturnCalendar> Get(CollectionTypes type)
        {
            return _retrunCalendarService.GetCurrent(type);
        }
    }
}