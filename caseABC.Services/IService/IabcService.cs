using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using caseABC.Data;
using caseABC.Services;

namespace caseABC.Services.IService
{
    interface IabcService
    {
        IList<Parcel> GetCustomerParcels(int customerId);
        void CreateCustomerParcel(int ParcelId);
        //edit for current parcels
        void EditCustomerParcel(int ParcelId);
        //delete for current parcels
        void DeleteCustomerParcel(int ParcelId);
        //Tracking
        //Should Simply be an IList of all Tracking Events
        IList<Tracking> GetTrackingEvents(int TrackingId);
    }
}
