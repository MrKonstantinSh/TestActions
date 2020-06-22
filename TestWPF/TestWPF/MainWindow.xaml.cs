using System.Windows;

namespace TestWPF
{
    partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            string message = Test(1, 2).ToString();
            MessageBox.Show(message, "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static int Test(int a, int b)
        {
            return a + b;
        }
    }
}