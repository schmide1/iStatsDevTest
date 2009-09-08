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
    public partial class leagueteamsmanagers : Page
    {
        public leagueteamsmanagers()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void HyperlinkButton_BindingValidationError(object sender, System.Windows.Controls.ValidationErrorEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }
    }
}
