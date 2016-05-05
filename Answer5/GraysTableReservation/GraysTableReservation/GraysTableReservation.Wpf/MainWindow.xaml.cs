using System.ComponentModel.Composition;
using GraysTableReservation.Wpf.ViewModels;
using MahApps.Metro.Controls;

namespace GraysTableReservation.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    [Export]
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        [Import]
        public MainViewModel MainViewModel
        {
            set { DataContext = value; }
        }
    }
}
