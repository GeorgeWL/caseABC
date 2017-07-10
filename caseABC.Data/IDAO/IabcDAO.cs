using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caseABC.Data.IDAO
{
    public interface IabcDAO
    {
     //Parcels
        //get IList of Parcels for One Customer
        IList<Parcel> GetCustomerParcels(int CustomerId);
        //In later iteration may instead split into 
        //GetAllparcels and GetCustomerParcels
        //IList<Parcel> GetAllParcels(int ParcelId)
        //create for new parcels
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
