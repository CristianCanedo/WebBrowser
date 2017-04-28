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

                // TO set blank
                // MyWebBrowser.Source = new Uri("about:blank");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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

        private void MyRefresh_Click(object sender, RoutedEventArgs e)
        {
            MyWebBrowser.Navigate(MyWebBrowser.Source.AbsoluteUri);
        }
    }
}
