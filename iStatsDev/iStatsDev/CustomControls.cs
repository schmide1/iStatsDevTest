using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace iStatsDev
{
    public class ccTextBox : TextBox
    {
        public ccTextBox()
        {
        }

        override protected void OnGotFocus(RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Color.FromArgb(255, 194, 195, 233));
            this.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            this.SelectAll();
            base.OnGotFocus(e);
        }

        override protected void OnLostFocus(RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            this.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            base.OnLostFocus(e);
        }
    }

}
