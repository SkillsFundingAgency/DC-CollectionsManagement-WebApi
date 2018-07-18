using System;
using System.Collections.Generic;
using System.Text;
using ESFA.DC.CollectionsManagement.Models;

namespace ESFA.DC.CollectionsManagement.Service
{
    public interface IOrganisationService
    {
        Organisation GetByUkprn(long ukprn);
        IEnumerable<Collection> GetAvailableCollections(long ukprn);
    }
}
