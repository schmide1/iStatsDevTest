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
            this.cboLeagueCountry.Items.Add("Canada");
			
			this.cboLeagueState.Items.Add("New Jersey");
            this.cboLeagueState.Items.Add("New York");
			this.cboLeagueState.Items.Add("Pennsylvania");
			
			this.cboLeagueState.Visibility=Visibility.Collapsed;
			this.txtLeagueScopeDetail.Visibility=Visibility.Collapsed;	
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
		
        }

        private void rdoCity_Checked(object sender, System.Windows.RoutedEventArgs e)
        { // TODO: Add event handler implementation here.
			this.cboLeagueState.Visibility=Visibility.Visible;
			this.txtLeagueScopeDetail.Visibility=Visibility.Visible;
     		this.txtLeagueScopeDetail.Text="Enter city";
		}
        
		private void txtLeagueScopeDetail_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.				
			if (this.txtLeagueScopeDetail.Text.Equals("Enter city")) {
				this.txtLeagueScopeDetail.Text = "";				
			}				
			
			//txtLeagueScopeDetail.Foreground = new SolidColorBrush(Colors.Black);
			//txtLeagueScopeDetail.Background = new SolidColorBrush(Color.FromArgb);
		
		}
    }
}
