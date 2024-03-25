using lab1_4.ViewModel;
using System.Windows;

namespace lab1_4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new SetVM();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}