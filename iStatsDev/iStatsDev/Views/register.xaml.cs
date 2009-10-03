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
using System.Text;

namespace iStatsDev
{
    public partial class register : Page
    {
        public enum userTypes : int
        {
            Admin = 0,
            Mod = 1,
            LeagueAdmin = 2,
            TeamCoach = 3,
            Player = 4,
            ScoreRecorder = 5,
            Fan = 6
        }

        public enum userStatus : int
        {
            Pending = 0,
            Active = 1,
            Locked = 2,
            Closed = 3
        }

        public enum userGender : int
        {
            Male = 0,
            Female = 1
        }

        public register()
        {
            InitializeComponent();

            // Populate Combo boxes
            
            // Gender
            this.cboGender.Items.Add("Male");
            this.cboGender.Items.Add("Female");

            // Country
            this.cboCountry.Items.Add("United States");
            this.cboCountry.Items.Add("Canada");

            // Month
            this.cboMonth.Items.Add("January");
            this.cboMonth.Items.Add("February");
            this.cboMonth.Items.Add("March");
            this.cboMonth.Items.Add("April");
            this.cboMonth.Items.Add("May");
            this.cboMonth.Items.Add("June");
            this.cboMonth.Items.Add("July");
            this.cboMonth.Items.Add("August");
            this.cboMonth.Items.Add("September");
            this.cboMonth.Items.Add("October");
            this.cboMonth.Items.Add("November");
            this.cboMonth.Items.Add("December");

        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            Svc.User usr = new iStatsDev.Svc.User();

            if (!validatePage())
                return;

            usr.CreationDT = DateTime.Now.ToUniversalTime();
            usr.Email = txtEmail.Text;
            usr.FirstName = txtFirstName.Text;
            usr.LastName = txtLastName.Text;
            usr.Status = (int)userStatus.Pending;
            usr.UserType = (int)userTypes.Player;

            if (cboGender.SelectedItem.ToString().Equals("male", StringComparison.CurrentCultureIgnoreCase))
            {
                usr.Gender = (int)userGender.Male;
            }
            else
            {
                usr.Gender = (int)userGender.Female;
            }

            Svc.Address add = new iStatsDev.Svc.Address();

            add.Address1 = txtStreet.Text;
            add.PostalCode = txtPostalCode.Text;
            add.Country = cboCountry.SelectedItem.ToString();

            usr.address = add;

            // Password hashing
            System.Security.Cryptography.SHA256Managed sha = new System.Security.Cryptography.SHA256Managed();

            // Salted with User ID to prevent dictionary hits
            byte[] hash = sha.ComputeHash(Encoding.Unicode.GetBytes(pwdPassword1.Password + usr.UserID));

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }

            usr.Password = sb.ToString();

            // Use webservice to save
            Svc.Service1Client svcClient = new iStatsDev.Svc.Service1Client();
            svcClient.SaveUserCompleted += new EventHandler<iStatsDev.Svc.SaveUserCompletedEventArgs>(svcClient_SaveUserCompleted);
            svcClient.SaveUserAsync(usr);
        }

        private bool validatePage()
        {
            return true;
        }

        void svcClient_SaveUserCompleted(object sender, iStatsDev.Svc.SaveUserCompletedEventArgs e)
        {
            if (e.Result)
                MessageBox.Show("Saved!");
            else
                MessageBox.Show("Error!");
        }

        private void pwdPassword1_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        {
        	this.pwdPassword1.Background = new SolidColorBrush(Color.FromArgb(255, 194, 195, 233));
            this.pwdPassword1.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            base.OnGotFocus(e);
        }

        private void pwdPassword1_LostFocus(object sender, System.Windows.RoutedEventArgs e)
        {
        	this.pwdPassword1.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            this.pwdPassword1.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            base.OnLostFocus(e);

            checkPassword();
        }

        private void checkPassword()
        {
            if ((pwdPassword2.Password.Length > 0) && (pwdPassword1.Password.Length > 0) && (!pwdPassword2.Password.Equals(pwdPassword1.Password)))
            {
                imgpasswordConfirmX.Visibility = Visibility.Visible;
            }
            else
            {
                imgpasswordConfirmX.Visibility = Visibility.Collapsed;
            }
        }
 
		private void pwdPassword2_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        {
        	this.pwdPassword2.Background = new SolidColorBrush(Color.FromArgb(255, 194, 195, 233));
            this.pwdPassword2.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            base.OnGotFocus(e);
        }

        private void pwdPassword2_LostFocus(object sender, System.Windows.RoutedEventArgs e)
        {
        	this.pwdPassword2.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            this.pwdPassword2.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            base.OnLostFocus(e);

            checkPassword();
        }
    }
}
