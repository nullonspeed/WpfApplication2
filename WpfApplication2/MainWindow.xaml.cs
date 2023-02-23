using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Input;
using System.Windows.Media;
namespace WpfApplication2
{
    public partial class MainWindow : Window
    {
            
        public MainWindow()
        {
            InitializeComponent();
            lv.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            if (lv.Visibility == Visibility.Visible)
            {
                lv.Visibility = Visibility.Hidden;
            }
            else
            {
                lv.Visibility = Visibility.Visible;
            }
            
            
            
            
            // Create a new ListView
           // var listView = new ListView();

            // Create a new Label
         //   var label = new Label();
           // label.Content = "Hello World!";

            // Create a new ListViewItem
            //var item = new ListViewItem();
            //item.Content = label;

            // Add the ListViewItem to the ListView
           // listView.Items.Add(item);

            // Add the ListView to the window
           // this.Content = listView;
            
           // lvp.Children.Add(listView);
            
        }
        
       /* private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Create a new Label
            var label = new Label();
            label.Content = "Hello World!";

            // Set the position of the label
            
            double x = e.GetPosition(this).X;
            double y = e.GetPosition(this).Y;
            
            MessageBox.Show(" "+x + y);
            
            
            Canvas.SetLeft(label, 23);
            Canvas.SetTop(label, 56);

            // Add the label to the window
            
            this.Content = label;

            
            
        }
        */
    }
    }