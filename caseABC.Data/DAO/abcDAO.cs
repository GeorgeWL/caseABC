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
        //private caseABCEntities _context;
        //use local context to create new objects
        //public abcDAO()
        //{
        //    _context = new caseABCEntities();
        //}
        public IList<Parcel> GetCustomerParcels(int CustomerId)
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
