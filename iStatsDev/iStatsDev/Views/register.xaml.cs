﻿using System;
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

        private void txtFirstName_GotFocus(object sender, RoutedEventArgs e)
        {
            txtFirstName.SelectAll();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            Svc.User usr = new iStatsDev.Svc.User();

            usr.CreationDT = DateTime.Now.ToUniversalTime();
            usr.Email = txtEmail.Text;
            usr.FirstName = txtFirstName.Text;
            usr.LastName = txtLastName.Text;
            usr.Status = (int)userStatus.Pending;
            usr.UserType = (int)userTypes.Player;
            usr.Password = pwdPassword1.Password;

            if (cboGender.SelectedItem.ToString().Equals("male", StringComparison.CurrentCultureIgnoreCase))
            {
                usr.Gender = (int)userGender.Male;
            }
            else
            {
                usr.Gender = (int)userGender.Female;
            }

            Svc.Service1Client svcClient = new iStatsDev.Svc.Service1Client();
            svcClient.SaveUserCompleted += new EventHandler<iStatsDev.Svc.SaveUserCompletedEventArgs>(svcClient_SaveUserCompleted);
            svcClient.SaveUserAsync(usr);
        }

        void svcClient_SaveUserCompleted(object sender, iStatsDev.Svc.SaveUserCompletedEventArgs e)
        {
            MessageBox.Show("Saved!");
        }

    }
}
