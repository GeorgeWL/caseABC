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
        void CreateCustomerParcel(Parcel parcel);
        //edit for current parcels
        void EditCustomerParcel(Parcel parcel);
        //delete for current parcels
        void DeleteCustomerParcel(Parcel parcel);
        //Tracking
        //Should Simply be an IList of all Tracking Events
        IList<Tracking> GetTrackingEvents(int TrackingId);
    }
}
