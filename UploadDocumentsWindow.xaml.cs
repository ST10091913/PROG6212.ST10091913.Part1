using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class UploadDocumentsWindow : Window
    {
        public UploadDocumentsWindow()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, RoutedEventArgs e)
        {
            // Handle the browse action here
            MessageBox.Show("Browse for document.");
        }

        private void Upload_Click(object sender, RoutedEventArgs e)
        {
            // Handle the upload action here
            MessageBox.Show("Document Uploaded!");//Chand.2023
        }
    }
}
//Reference:
//Chand.M,2023 C# messageBox, C#corner, 12 July 2023,[online], accessible at:https://www.c-sharpcorner.com/UploadFile/mahesh/understanding-message-box-in-windows-forms-using-C-Sharp/