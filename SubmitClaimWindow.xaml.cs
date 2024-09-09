using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class SubmitClaimWindow : Window
    {
        public SubmitClaimWindow()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            // Handle the submit action here
            MessageBox.Show("Claim Submitted!");
        }
    }
}
