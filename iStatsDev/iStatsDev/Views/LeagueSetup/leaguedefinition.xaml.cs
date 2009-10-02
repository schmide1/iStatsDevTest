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
    public partial class leaguedefinition : Page
    {
        public leaguedefinition()
        {
            InitializeComponent();	

			this.cboLeagueCountry.Items.Add("United States");
			
			this.cboLeagueState.Items.Add("New Jersey");
            this.cboLeagueState.Items.Add("New York");
			this.cboLeagueState.Items.Add("Pennsylvania");
			
			this.cboLeagueSport.Items.Add("Baseball");
			this.cboLeagueSport.Items.Add("Basketball");
			this.cboLeagueSport.Items.Add("Golf");
			this.cboLeagueSport.Items.Add("Soccer");
			
			this.cboLeagueYear.Items.Add("2009");
			this.cboLeagueYear.Items.Add("2010");
						
			this.stkLeagueState.Visibility=Visibility.Collapsed;
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
		
        }

        private void rdoCity_Checked(object sender, System.Windows.RoutedEventArgs e)
        { // TODO: Add event handler implementation here.
			this.stkLeagueState.Visibility=Visibility.Visible;
			this.txtLeagueScopeDetail.Visibility=Visibility.Visible;
     		
			if (this.txtLeagueScopeDetail.Text.Equals("") || (this.txtLeagueScopeDetail.Text.Equals("Enter county"))) {
				this.txtLeagueScopeDetail.Text="Enter city";
			}
		}
		
		private void rdoCounty_Checked(object sender, System.Windows.RoutedEventArgs e)
        { // TODO: Add event handler implementation here.
			this.stkLeagueState.Visibility=Visibility.Visible;
			this.txtLeagueScopeDetail.Visibility=Visibility.Visible;
     		
			if (this.txtLeagueScopeDetail.Text.Equals("") || (this.txtLeagueScopeDetail.Text.Equals("Enter city"))) {
				this.txtLeagueScopeDetail.Text="Enter county";
			}
		}
		
		private void rdoState_Checked(object sender, System.Windows.RoutedEventArgs e)
        { // TODO: Add event handler implementation here.
			this.stkLeagueState.Visibility=Visibility.Visible;
			this.txtLeagueScopeDetail.Visibility=Visibility.Collapsed;
     		
		}
		
		private void rdoCountry_Checked(object sender, System.Windows.RoutedEventArgs e)
        { // TODO: Add event handler implementation here.
			this.stkLeagueState.Visibility=Visibility.Collapsed;
		}
		
		private void rdoInternational_Checked(object sender, System.Windows.RoutedEventArgs e)
        { // TODO: Add event handler implementation here.
			this.stkLeagueState.Visibility=Visibility.Collapsed;
		}
        
		private void txtLeagueScopeDetail_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.				
			if (this.txtLeagueScopeDetail.Text.Equals("Enter city") || (this.txtLeagueScopeDetail.Text.Equals("Enter county")))
				this.txtLeagueScopeDetail.Text = "";						
		}

		private void btnNext_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			
		}
    }
}
