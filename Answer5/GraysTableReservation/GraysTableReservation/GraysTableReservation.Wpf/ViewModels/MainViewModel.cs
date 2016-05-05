using System.ComponentModel.Composition;

namespace GraysTableReservation.Wpf.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class MainViewModel
    {
        [Import]
        public ReservationsViewModel ReservationsViewModel { get; set; }
        
        [Import]
        public DashboardViewModel DashboardViewModel { get; set; }
    }
}
