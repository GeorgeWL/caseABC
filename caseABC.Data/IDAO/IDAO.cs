﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caseABC.Data.IDAO
{
    public interface IDAO
    {
     //Parcels
        //get IList of Parcels for One Customer
        IList<Parcel> GetCustomerParcels(int CustomerId);
        //In later iteration may instead split into 
        //GetAllparcels and GetCustomerParcels
        //IList<Parcel> GetAllParcels(int ParcelId)
        //create
        void CreateCustomerParcel(int ParcelId);
        //edit
        void EditCustomerParcel(int ParcelId);
        //delete
        void DeleteCustomerParcel(int ParcelId);
    //Tracking
        //Should Simply be an IList of all Tracking Events
        IList<Tracking> GetTrackingEvents(int TrackingId);
    }
}