#pragma checksum "C:\Users\Ed\iStatsDevTest\iStatsDev\iStatsDev\Views\register.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FDFEF307206C56E25EE463929A09DB5D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;
using iStatsDev;


namespace iStatsDev {
    
    
    public partial class register : System.Windows.Controls.Page {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid grdRegister;
        
        internal System.Windows.Controls.Grid grdOne;
        
        internal System.Windows.Controls.TextBlock txtBasicInfoHeader;
        
        internal System.Windows.Controls.TextBlock lblMyName;
        
        internal System.Windows.Controls.TextBlock lblPostalCode;
        
        internal System.Windows.Controls.TextBlock lblBirthday;
        
        internal System.Windows.Controls.ComboBox cboMonth;
        
        internal iStatsDev.ccTextBox txtBirthdayDay;
        
        internal iStatsDev.ccTextBox txtBirthdayYear;
        
        internal System.Windows.Controls.TextBlock lblGender;
        
        internal System.Windows.Controls.TextBlock lblStreet;
        
        internal iStatsDev.ccTextBox txtStreet;
        
        internal System.Windows.Controls.ComboBox cboGender;
        
        internal iStatsDev.ccTextBox txtPostalCode;
        
        internal System.Windows.Controls.TextBlock lblCountry;
        
        internal System.Windows.Controls.ComboBox cboCountry;
        
        internal iStatsDev.ccTextBox txtFirstName;
        
        internal iStatsDev.ccTextBox txtLastName;
        
        internal System.Windows.Controls.Image imgnameCheck;
        
        internal System.Windows.Controls.Image imgnameX;
        
        internal System.Windows.Controls.Image imggenderCheck;
        
        internal System.Windows.Controls.Image imggenderX;
        
        internal System.Windows.Controls.Image imgbirthdayCheck;
        
        internal System.Windows.Controls.Image imgbirthdayX;
        
        internal System.Windows.Controls.Image imgstreetCheck;
        
        internal System.Windows.Controls.Image imgstreetX;
        
        internal System.Windows.Controls.Image imgcountryCheck;
        
        internal System.Windows.Controls.Image imgcountryX;
        
        internal System.Windows.Controls.Image imgpostalCheck;
        
        internal System.Windows.Controls.Image imgpostalX;
        
        internal System.Windows.Controls.Grid grdTwo;
        
        internal System.Windows.Controls.TextBlock txtIDHeader;
        
        internal System.Windows.Controls.TextBlock lblUserID;
        
        internal iStatsDev.ccTextBox txtUserID;
        
        internal System.Windows.Controls.TextBlock lblPassword1;
        
        internal System.Windows.Controls.PasswordBox pwdPassword1;
        
        internal System.Windows.Controls.TextBlock lblPassword2;
        
        internal System.Windows.Controls.PasswordBox pwdPassword2;
        
        internal System.Windows.Controls.TextBlock lblEmail;
        
        internal iStatsDev.ccTextBox txtEmail;
        
        internal System.Windows.Controls.Image imguseridCheck;
        
        internal System.Windows.Controls.Image imguseridX;
        
        internal System.Windows.Controls.Image imgemailCheck;
        
        internal System.Windows.Controls.Image imgemailX;
        
        internal System.Windows.Controls.Image imgpasswordCheck;
        
        internal System.Windows.Controls.Image imgpasswordX;
        
        internal System.Windows.Controls.Image imgpasswordConfirmCheck;
        
        internal System.Windows.Controls.Image imgpasswordConfirmX;
        
        internal System.Windows.Controls.Grid grdThree;
        
        internal System.Windows.Controls.TextBlock txtCaptchaHeader;
        
        internal System.Windows.Shapes.Rectangle recCaptcha;
        
        internal System.Windows.Controls.Grid grdFour;
        
        internal System.Windows.Controls.TextBlock txtStep4Header;
        
        internal System.Windows.Controls.Button btnCreate;
        
        internal System.Windows.Controls.Button btnCancel;
        
        internal System.Windows.Shapes.Path lineHoriz;
        
        internal System.Windows.Shapes.Path lineVert;
        
        internal System.Windows.Controls.Grid grdSignIn;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/iStatsDev;component/Views/register.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.grdRegister = ((System.Windows.Controls.Grid)(this.FindName("grdRegister")));
            this.grdOne = ((System.Windows.Controls.Grid)(this.FindName("grdOne")));
            this.txtBasicInfoHeader = ((System.Windows.Controls.TextBlock)(this.FindName("txtBasicInfoHeader")));
            this.lblMyName = ((System.Windows.Controls.TextBlock)(this.FindName("lblMyName")));
            this.lblPostalCode = ((System.Windows.Controls.TextBlock)(this.FindName("lblPostalCode")));
            this.lblBirthday = ((System.Windows.Controls.TextBlock)(this.FindName("lblBirthday")));
            this.cboMonth = ((System.Windows.Controls.ComboBox)(this.FindName("cboMonth")));
            this.txtBirthdayDay = ((iStatsDev.ccTextBox)(this.FindName("txtBirthdayDay")));
            this.txtBirthdayYear = ((iStatsDev.ccTextBox)(this.FindName("txtBirthdayYear")));
            this.lblGender = ((System.Windows.Controls.TextBlock)(this.FindName("lblGender")));
            this.lblStreet = ((System.Windows.Controls.TextBlock)(this.FindName("lblStreet")));
            this.txtStreet = ((iStatsDev.ccTextBox)(this.FindName("txtStreet")));
            this.cboGender = ((System.Windows.Controls.ComboBox)(this.FindName("cboGender")));
            this.txtPostalCode = ((iStatsDev.ccTextBox)(this.FindName("txtPostalCode")));
            this.lblCountry = ((System.Windows.Controls.TextBlock)(this.FindName("lblCountry")));
            this.cboCountry = ((System.Windows.Controls.ComboBox)(this.FindName("cboCountry")));
            this.txtFirstName = ((iStatsDev.ccTextBox)(this.FindName("txtFirstName")));
            this.txtLastName = ((iStatsDev.ccTextBox)(this.FindName("txtLastName")));
            this.imgnameCheck = ((System.Windows.Controls.Image)(this.FindName("imgnameCheck")));
            this.imgnameX = ((System.Windows.Controls.Image)(this.FindName("imgnameX")));
            this.imggenderCheck = ((System.Windows.Controls.Image)(this.FindName("imggenderCheck")));
            this.imggenderX = ((System.Windows.Controls.Image)(this.FindName("imggenderX")));
            this.imgbirthdayCheck = ((System.Windows.Controls.Image)(this.FindName("imgbirthdayCheck")));
            this.imgbirthdayX = ((System.Windows.Controls.Image)(this.FindName("imgbirthdayX")));
            this.imgstreetCheck = ((System.Windows.Controls.Image)(this.FindName("imgstreetCheck")));
            this.imgstreetX = ((System.Windows.Controls.Image)(this.FindName("imgstreetX")));
            this.imgcountryCheck = ((System.Windows.Controls.Image)(this.FindName("imgcountryCheck")));
            this.imgcountryX = ((System.Windows.Controls.Image)(this.FindName("imgcountryX")));
            this.imgpostalCheck = ((System.Windows.Controls.Image)(this.FindName("imgpostalCheck")));
            this.imgpostalX = ((System.Windows.Controls.Image)(this.FindName("imgpostalX")));
            this.grdTwo = ((System.Windows.Controls.Grid)(this.FindName("grdTwo")));
            this.txtIDHeader = ((System.Windows.Controls.TextBlock)(this.FindName("txtIDHeader")));
            this.lblUserID = ((System.Windows.Controls.TextBlock)(this.FindName("lblUserID")));
            this.txtUserID = ((iStatsDev.ccTextBox)(this.FindName("txtUserID")));
            this.lblPassword1 = ((System.Windows.Controls.TextBlock)(this.FindName("lblPassword1")));
            this.pwdPassword1 = ((System.Windows.Controls.PasswordBox)(this.FindName("pwdPassword1")));
            this.lblPassword2 = ((System.Windows.Controls.TextBlock)(this.FindName("lblPassword2")));
            this.pwdPassword2 = ((System.Windows.Controls.PasswordBox)(this.FindName("pwdPassword2")));
            this.lblEmail = ((System.Windows.Controls.TextBlock)(this.FindName("lblEmail")));
            this.txtEmail = ((iStatsDev.ccTextBox)(this.FindName("txtEmail")));
            this.imguseridCheck = ((System.Windows.Controls.Image)(this.FindName("imguseridCheck")));
            this.imguseridX = ((System.Windows.Controls.Image)(this.FindName("imguseridX")));
            this.imgemailCheck = ((System.Windows.Controls.Image)(this.FindName("imgemailCheck")));
            this.imgemailX = ((System.Windows.Controls.Image)(this.FindName("imgemailX")));
            this.imgpasswordCheck = ((System.Windows.Controls.Image)(this.FindName("imgpasswordCheck")));
            this.imgpasswordX = ((System.Windows.Controls.Image)(this.FindName("imgpasswordX")));
            this.imgpasswordConfirmCheck = ((System.Windows.Controls.Image)(this.FindName("imgpasswordConfirmCheck")));
            this.imgpasswordConfirmX = ((System.Windows.Controls.Image)(this.FindName("imgpasswordConfirmX")));
            this.grdThree = ((System.Windows.Controls.Grid)(this.FindName("grdThree")));
            this.txtCaptchaHeader = ((System.Windows.Controls.TextBlock)(this.FindName("txtCaptchaHeader")));
            this.recCaptcha = ((System.Windows.Shapes.Rectangle)(this.FindName("recCaptcha")));
            this.grdFour = ((System.Windows.Controls.Grid)(this.FindName("grdFour")));
            this.txtStep4Header = ((System.Windows.Controls.TextBlock)(this.FindName("txtStep4Header")));
            this.btnCreate = ((System.Windows.Controls.Button)(this.FindName("btnCreate")));
            this.btnCancel = ((System.Windows.Controls.Button)(this.FindName("btnCancel")));
            this.lineHoriz = ((System.Windows.Shapes.Path)(this.FindName("lineHoriz")));
            this.lineVert = ((System.Windows.Shapes.Path)(this.FindName("lineVert")));
            this.grdSignIn = ((System.Windows.Controls.Grid)(this.FindName("grdSignIn")));
        }
    }
}
