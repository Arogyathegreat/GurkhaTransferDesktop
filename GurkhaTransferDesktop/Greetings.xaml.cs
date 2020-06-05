using System.Windows;

namespace GurkhaTransferDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (HelloButton.IsChecked == true)
                MessageBox.Show("Hello");
            else if (GoodByeButton.IsChecked == true)
                MessageBox.Show("Goodbye");
        }
    }
}