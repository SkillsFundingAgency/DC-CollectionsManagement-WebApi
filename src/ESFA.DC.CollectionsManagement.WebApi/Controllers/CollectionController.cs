using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESFA.DC.CollectionsManagement.Models;
using ESFA.DC.CollectionsManagement.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ESFA.DC.CollectionsManagement.WebApi.Controllers
{
    [Route("api/collections")]
    public class CollectionController : Controller
    {
        private readonly IOrganisationService _organisationService;

        public CollectionController(IOrganisationService organisationService)
        {
            _organisationService = organisationService;
        }

        // GET api/values/5
        [HttpGet("{ukprn}/{collectionType}")]
        public IEnumerable<Collection> Get(long ukprn, string collectionType)
        {
            return _organisationService.GetAvailableCollections(ukprn, collectionType);
        }
    }
}