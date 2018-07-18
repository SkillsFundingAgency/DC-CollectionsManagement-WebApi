using System;
using System.Collections.Generic;
using System.Text;
using ESFA.DC.CollectionsManagement.Models;

namespace ESFA.DC.CollectionsManagement.Service
{
    public interface IRetrunCalendarService
    {
        IEnumerable<ReturnCalendar> GetCurrent(CollectionTypes collectionType);
    }
}
