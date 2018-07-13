using System;
using System.Collections.Generic;
using System.Text;
using ESFA.DC.CollectionsManagement.Models;

namespace ESFA.DC.CollectionsManagement.Service
{
    public class OrganisationService : IOrganisationService
    {
        public IEnumerable<Collection> GetAvailableCollections(long ukprn)
        {
            throw new NotImplementedException();
        }

        public Organisation GetByUkprn(long ukprn)
        {
            throw new NotImplementedException();
        }
    }
}
