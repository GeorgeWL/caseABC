using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using caseABC.Data;
using caseABC.Services.IService;

namespace caseABC.Services.Service
{
    public class abcService : IabcService
    {
        public IList<Parcel> GetCustomerParcels(int customerId)
        {
            throw new NotImplementedException();
        }

        public void CreateCustomerParcel(int ParcelId)
        {
            throw new NotImplementedException();
        }

        public void EditCustomerParcel(int ParcelId)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomerParcel(int ParcelId)
        {
            throw new NotImplementedException();
        }

        public IList<Tracking> GetTrackingEvents(int TrackingId)
        {
            throw new NotImplementedException();
        }
    }
}
