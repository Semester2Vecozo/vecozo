﻿using BusinessLayer;
using System;

namespace ViewLayer.Models
{
    public class ReservationViewModel
    {
        public int Id;
        public int User_id;
        public int Workzone_id;
        public DateTime DateTime_Arriving;
        public DateTime DateTime_Leaving;

        public ReservationViewModel(Reservation reservation)
        {
            this.Id = reservation.id;
            this.User_id = reservation.User_id;
            this.Workzone_id = reservation.Workzone_id;
            this.DateTime_Arriving = reservation.DateTime_Arriving;
            this.DateTime_Leaving = reservation.DateTime_Leaving;   
            
        }

        //public ReservationViewModel()
        //{
        //}
    }
}
