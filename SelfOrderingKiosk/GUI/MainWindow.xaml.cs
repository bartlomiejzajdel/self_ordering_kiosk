using GUI.ViewModels;
using System.Windows;
using DataAccess;
using System.Windows.Controls;
using System.Xml.Serialization;
using System.IO;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            ButtonBurgers_Click(this, null);
            UpdateCurrentAmmount();
            UpdateNumberOfItems();
            ClearBasketButton.IsEnabled = false;
            ViewOrderButton.IsEnabled = false;
        }

        internal void ButtonBurgers_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new BurgersViewModel();
            GoToPaymentButton.Visibility = Visibility.Collapsed;
            ViewOrderButton.Visibility = Visibility.Visible;
        }

        private void ButtonFries_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new FriesViewModel();
            GoToPaymentButton.Visibility = Visibility.Collapsed;
            ViewOrderButton.Visibility = Visibility.Visible;
        }

        private void ButtonDrinks_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new DrinksViewModel();
            GoToPaymentButton.Visibility = Visibility.Collapsed;
            ViewOrderButton.Visibility = Visibility.Visible;
        }

        private void ViewOrder_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new OrderViewModel();
            ViewOrderButton.Visibility = Visibility.Collapsed;
            GoToPaymentButton.Visibility = Visibility.Visible;
        }

        public void UpdateCurrentAmmount()
        {
            TxtBlockCurrentAmmount.Text = CurrentOrder.TotalAmount.ToString("c");
            TxtBlockCurrentAmmount.TextAlignment = TextAlignment.Center;
        }
        public void UpdateNumberOfItems()
        {
            TxtBlockNumberOfItems.Text = CurrentOrder.NumberOfItems.ToString();
            TxtBlockNumberOfItems.TextAlignment = TextAlignment.Center;
        }

        private void ClearOrder_Click(object sender, RoutedEventArgs e)
        {
            CurrentOrder.ClearCurrentOrder();
            UpdateCurrentAmmount();
            UpdateNumberOfItems();
            ClearBasketButton.IsEnabled = false;
            ViewOrderButton.IsEnabled = false;
            var button = (Button)sender;
            if (button.DataContext.GetType() == typeof(OrderViewModel))
                ButtonBurgers_Click(this, null);
        }

        private void GoToPayment_Click(object sender, RoutedEventArgs e)
        {
            PaymentWindow objpaymentWindow = new PaymentWindow(this);
            objpaymentWindow.ShowDialog();
        }
    }
}




