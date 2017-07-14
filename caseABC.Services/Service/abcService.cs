using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using caseABC.Data;
using caseABC.Data.DAO;
using caseABC.Services.IService;

namespace caseABC.Services.Service
{
    public class abcService : IabcService
    {
        private abcDAO _abcDAO;
        public abcService() { _abcDAO = new abcDAO(); }
        public IList<Parcel> GetCustomerParcels(int customerId)
        {
            return _abcDAO.GetCustomerParcels(customerId);
        }

        public void CreateCustomerParcel(int parcelId)
        {
            _abcDAO.CreateCustomerParcel(parcelId);
        }

        public void EditCustomerParcel(int parcelId)
        {
            _abcDAO.EditCustomerParcel(parcelId);
        }

        public void DeleteCustomerParcel(int parcelId)
        {
            _abcDAO.DeleteCustomerParcel(parcelId);
        }

        public IList<Tracking> GetTrackingEvents(int parcelId)
        {
            return _abcDAO.GetTrackingEvents(parcelId);
        }
    }
}
