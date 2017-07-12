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

        public void CreateCustomerParcel(int parcelId)
        {
            Parcel parcels =
                (from parcel
                 in _context.Parcel
                 //where parcel.parcelId == parcel.parcelId
                 select parcel).ToList<Parcel>().First();
            //change from context of parcels to equal parcel
            //parcels.parcelId = parcelId.parcelId;
            //parcels.customerId = parcelId.customerId;
            //parcels.pickupAddress = parcelId.pickupAddress;
            //parcels.pickupDate = parcelId.pickupDate;
            _context.Parcel.Add(parcels);
            _context.SaveChanges();
            //throw new NotImplementedException();
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
