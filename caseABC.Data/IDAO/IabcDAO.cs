﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using caseABC.Data;
using caseABC.Data.DAO;
using caseABC.Data.IDAO;

namespace caseABC.Data.IDAO
{
    public interface IabcDAO
    {
     //Parcels
        //get IList of Parcels for One Customer
        IList<Parcel> GetCustomerParcels(int customerId);
        //In later iteration may instead split into 
        //GetAllparcels and GetCustomerParcels
        //IList<Parcel> GetAllParcels(int ParcelId)
        //create for new parcels
        void CreateCustomerParcel(Parcel parcel);
        //edit for current parcels
        void EditCustomerParcel(int parcelId);
        //delete for current parcels
        void DeleteCustomerParcel(Parcel parcel);
    //Tracking
        //Should Simply be an IList of all Tracking Events
        IList<Tracking> GetTrackingEvents(int parcelId);
    }
}
