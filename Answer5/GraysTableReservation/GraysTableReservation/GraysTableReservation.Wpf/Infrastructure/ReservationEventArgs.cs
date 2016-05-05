using System;
using GraysTableReservation.Models;

namespace GraysTableReservation.Wpf.Infrastructure
{
    public class ReservationEventArgs : EventArgs
    {
        public ReservationEventArgs(Reservation reservation, bool isAdded)
        {
            Reservation = reservation;
            IsAdded = isAdded;
        }

        public Reservation Reservation { get; private set; }
        public bool IsAdded { get; private set; }
    }
}
