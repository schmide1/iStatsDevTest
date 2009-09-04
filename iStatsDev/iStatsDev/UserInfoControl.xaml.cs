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
using System.Text.RegularExpressions;

namespace myistats
{
    public enum userTypes : int
    {
        Admin = 0,
        Mod = 1,
        LeagueOwner = 2,
        TeamCoach = 3,
        Player = 4,
        ScoreRecorder = 5
    }

    public enum userStatus : int
    {
        Pending = 0,
        Active = 1,
        Locked = 2,
        Closed = 3
    }

    public partial class UserInfoControl : UserControl
    {
        bool isPassOk = false;
        bool isFNameOk = false;
        bool isLNameOk = false;
        bool isEmailOk = false;

        bool returnControl = false;

        private Grid grdRef = null;

        public enum userInfoControlMode
        {
            UserInfo,
            UserRegistration
        }

        private userInfoControlMode controlMode;

        public UserInfoControl(Grid grd, int col, int row, userInfoControlMode mode)
        {
            InitializeComponent();

            grdRef = grd;

            grdRef.Children.Add(this);

            Grid.SetColumn(this, col);
            Grid.SetRow(this, row);

            this.HorizontalAlignment = HorizontalAlignment.Left;

            controlMode = mode;

            if (controlMode == userInfoControlMode.UserInfo)
            {
                foreach (object o in LayoutRoot.Children)
                {
                    if (o is PasswordBox)
                    {
                        ((PasswordBox)o).Visibility = Visibility.Collapsed;
                    }
                    else if (o is TextBox)
                    {
                        ((TextBox)o).IsEnabled = false;
                    }
                }
            }
        }

        private void txtPass_LostFocus(object sender, RoutedEventArgs e)
        {
            /* Validate the password */
            bool? isPassFormatOk = null;
            bool? isVerificationOk = null;

            if (txtPass.Password.Length > 0)
                isPassFormatOk = Regex.IsMatch(txtPass.Password, @"^(?=.*[A-Za-z])(?=.*[0-9])(?!.*\s).{6,12}$");

            if (isPassFormatOk == false)
            {
                lblPassWarning.Visibility = Visibility.Visible;
            }
            else
            {
                lblPassWarning.Visibility = Visibility.Collapsed;
            }

            if (txtVerifyPass.Password.Length > 0 && !txtPass.Password.Equals(txtVerifyPass.Password))
            {
                lblPassVerificationWarning.Visibility = Visibility.Visible;
                isVerificationOk = false;
            }
            else
            {
                lblPassVerificationWarning.Visibility = Visibility.Collapsed;
                isVerificationOk = true;
            }

            if (isPassFormatOk == true && isVerificationOk == true)
                isPassOk = true;
            else
                isPassOk = false;

            validateForm();
        }

        private void validateForm()
        {
            if (isPassOk && isFNameOk && isLNameOk && isEmailOk)
                btnRegister.IsEnabled = true;
        }


        private void txtEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            isEmailOk = Regex.IsMatch(((TextBox)sender).Text, @"[a-zA-Z0-9_\-\.]+@[a-zA-Z0-9_\-\.]+\.[a-zA-Z]{2,5}");

            if (isEmailOk == false)
                lblEmailWarning.Visibility = Visibility.Visible;
            else
                lblEmailWarning.Visibility = Visibility.Collapsed;

            validateForm();
        }

        private void txtFirstName_LostFocus(object sender, RoutedEventArgs e)
        {
            isFNameOk = (((TextBox)sender).Text.Length >= 2) ? true : false;

            if (isFNameOk == true)
                isFNameOk = Regex.IsMatch(((TextBox)sender).Text, @"^[a-zA-Z]+$");

            if (isFNameOk == false)
                lblFNameWarning.Visibility = Visibility.Visible;
            else
                lblFNameWarning.Visibility = Visibility.Collapsed;

            validateForm();
        }

        private void txtMiddleName_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtLastName_LostFocus(object sender, RoutedEventArgs e)
        {
            isLNameOk = (((TextBox)sender).Text.Length >= 2) ? true : false;

            if (isLNameOk == true)
                isLNameOk = Regex.IsMatch(((TextBox)sender).Text, @"^[a-zA-Z]+$");

            if (isLNameOk == false)
                lblLNameWarning.Visibility = Visibility.Visible;
            else
                lblLNameWarning.Visibility = Visibility.Collapsed;

            validateForm();
        }

        private void btnCanel_Click(object sender, RoutedEventArgs e)
        {
            grdRef.Children.Remove(this);
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference1.User usr = new myistats.ServiceReference1.User();

            usr.CreationDT = DateTime.Now.ToUniversalTime();
            usr.Email = txtEmail.Text;
            usr.FirstName = txtFirstName.Text;
            usr.LastName = txtLastName.Text;
            usr.MiddleName = txtMiddleName.Text;
            usr.Status = (int)userStatus.Pending;
            usr.UserType = (int)userTypes.Player;
            usr.Password = System.Security.Cryptography.SHA256Managed

            ServiceReference1.Service1Client svc = new myistats.ServiceReference1.Service1Client();
            svc.SaveUserCompleted += new EventHandler<myistats.ServiceReference1.SaveUserCompletedEventArgs>(svc_SaveUserCompleted);
            svc.SaveUserAsync(usr);
        }

        void svc_SaveUserCompleted(object sender, myistats.ServiceReference1.SaveUserCompletedEventArgs e)
        {
            if (e.Result)
                btnRegister.Content = "Saved!";
            else
                btnRegister.Content = "Error!";
        }
    }
}
