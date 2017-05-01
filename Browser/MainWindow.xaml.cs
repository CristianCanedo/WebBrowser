using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Browser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // If you want to define a default URI then you can define like below...
                MyWebBrowser.Source = new Uri("http://www.google.com");

                // To set blank URI use statement below
                // MyWebBrowser.Source = new Uri("about:blank");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // This method handles the action when a user clicks the "Back" button on the browser.
        // It sends the user to the previous page he or she visited
        private void MyBack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MyWebBrowser.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // This method handles the action when a user clicks the "Forward" button on 
        // the browser and sends them to the web page after the previous or current.
        private void MyForward_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MyWebBrowser.GoForward();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // This method handles the action when a user clicks the "Go" button on the browser
        // It sends them to whatever website they input in their browser.
        private void MyGo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MyWebBrowser.Source = new Uri("http://" + MyTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void MyWebBrowser_LoadCompleted(object sender, NavigationEventArgs e)
        {
            MessageBox.Show("Completed.");
        }

        // Handles the action when the user presses the "Refresh" button on
        // the browser. Reloads the web page by loading the current URI again.
        private void MyRefresh_Click(object sender, RoutedEventArgs e)
        {
            MyWebBrowser.Navigate(MyWebBrowser.Source.AbsoluteUri);
        }
    }
}
