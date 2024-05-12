using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AsyncAxis2Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ServiceReference2.TextFileContentRetrieverPortTypeClient client;
        //This timer will be used to display the seconds elapsed since the Get Content
        //button was pressed
        private Timer GetContentTimer = new Timer(1);
        private int Seconds = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void GetResultAndUpdateLabels(IAsyncResult result)
        {
            this.Dispatcher.Invoke(() =>
            {
                txtFileContent.Text = client.EndretrieveTextFileContent(result);
                lblBlocked.Content = "";
                GetContentTimer.Stop();
            });
        }
        private void UpdateLabel(object sender, ElapsedEventArgs e)
        {
            this.Dispatcher.Invoke(() =>
            {
                //For every second that passed we update the label
                lblBlocked.Content = "Miliseconds elapsed: " + Seconds;
                Seconds += 1;
            });
        }
        private void btnGetContent_Click(object sender, RoutedEventArgs e)
        {
            string fileName = txtFileName.Text;
            try
            {
                client = new
               ServiceReference2.TextFileContentRetrieverPortTypeClient();
                //The UpdateLabel callback will be called every time a second has elapsed
                GetContentTimer.Elapsed += UpdateLabel;
                GetContentTimer.Start();
                //The GetResultAndUpdateLabels callback is called when the
                //retrieveTextfilecontent has finished
                IAsyncResult result = client.BeginretrieveTextFileContent(
               fileName,
               new AsyncCallback(GetResultAndUpdateLabels),
               null
               );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblBlocked.Content = "";
            }
            finally
            {
                //We reset the label content and the seconds elapsed
                Seconds = 0;
                lblBlocked.Content = "";
            }
        }
        private void btnDoSomething_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Do something else ...");
        }

    }
}
