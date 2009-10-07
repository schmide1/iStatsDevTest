using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace iStatsDev
{
    public partial class login : Page
    {
        public login()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            string strUser = txtLogin.Text;
            string strPass = txtPassword.Password;
            string strHash = UtilClass.GetPasswordHash(strUser, strPass);

            Svc.Service1Client svcClient = new iStatsDev.Svc.Service1Client();
            svcClient.LoginUserCompleted += new EventHandler<iStatsDev.Svc.LoginUserCompletedEventArgs>(svcClient_LoginUserCompleted);
            svcClient.LoginUserAsync(strUser, strHash);
        }

        void svcClient_LoginUserCompleted(object sender, iStatsDev.Svc.LoginUserCompletedEventArgs e)
        {
            if (!e.Result)
            {
                MessageBox.Show("Loggin failed!");
            }
            else
            {
                MessageBox.Show("Logged in");
            }
        }
    }
}
