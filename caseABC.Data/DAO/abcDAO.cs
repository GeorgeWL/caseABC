using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using caseABC.Data;
using caseABC.Data.DAO;
using caseABC.Data.IDAO;

namespace caseABC.Data.DAO
{
    //DAO class inherits from the IDAO Class
    public class abcDAO : IabcDAO
    {
        //stores ABCentities locally into a db context
        private ABC_Entities _context;
        //use local context to create new objects
        public abcDAO()
        {
            _context = new ABC_Entities();
         }
        public IList<Parcel> GetCustomerParcels(int customerId)
        {
        //make an Iquery of the parcel table in database and store it in _parcels
            IQueryable<Parcel> _parcel;
            //let Iquery know what _parcel object represents
            _parcel = from parcel
                          in _context.Parcel
                          where parcel.customerId == customerId
                          select parcel;
            return _parcel.ToList<Parcel>();
            //throw new NotImplementedException();
        }

        public void CreateCustomerParcel(Parcel parcel)
        {
            //Parcel parcels =
            //    (from parcel
            //     in _context.Parcel
            //     //where parcel.parcelId == parcel.parcelId
            //     select parcel).ToList<Parcel>().First();
            //change from context of parcels to equal parcel
            //parcels.parcelId = parcelId.parcelId;
            //parcels.customerId = parcelId.customerId;
            //parcels.pickupAddress = parcelId.pickupAddress;
            //parcels.pickupDate = parcelId.pickupDate;
            //
            //
            //That's definitely wrong...I'll have to figure that out
            //
            //
            _context.Parcel.Add(parcel);
            _context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void EditCustomerParcel(Parcel parcel)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomerParcel(int ParcelId)
        {
            throw new NotImplementedException();
        }

        public IList<Tracking> GetTrackingEvents(int TrackingId)
        {
            //make an Iquery of the Tracking table in database and store it in _trackings
            IQueryable<Tracking> _tracking;
            //let Iquery know what _parcel object represents
            _tracking = from tracking
                          in _context.Tracking
                      where tracking.TrackingId == TrackingId
                      select tracking;
            return _tracking.ToList<Tracking>();
            //throw new NotImplementedException();
        }

    }
}
