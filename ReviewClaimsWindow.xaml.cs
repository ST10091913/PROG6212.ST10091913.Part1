using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class ReviewClaimsWindow : Window
    {
        public ReviewClaimsWindow()
        {
            InitializeComponent();
        }

        private void Approve_Click(object sender, RoutedEventArgs e)
        {
            // Handle the approve action here
            MessageBox.Show("Claim Approved!");
        }

        private void Reject_Click(object sender, RoutedEventArgs e)
        {
            // Handle the reject action here
            MessageBox.Show("Claim Rejected!");
        }
    }
}
