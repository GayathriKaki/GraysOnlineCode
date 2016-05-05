using GraysTableReservation.Models;
using Microsoft.Practices.Prism.PubSubEvents;

namespace GraysTableReservation.Wpf.Infrastructure
{
    public sealed class ReservationAddOrEditEvent : PubSubEvent<Reservation> { }
    public sealed class ReservationDeletedEvent : PubSubEvent<Reservation> { }
}
