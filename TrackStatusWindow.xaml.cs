using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class TrackStatusWindow : Window
    {
        public TrackStatusWindow()
        {
            InitializeComponent();
        }

        private void Track_Click(object sender, RoutedEventArgs e)
        {
            // Handle the track action here
            MessageBox.Show("Tracking status...");
        }
    }
}
