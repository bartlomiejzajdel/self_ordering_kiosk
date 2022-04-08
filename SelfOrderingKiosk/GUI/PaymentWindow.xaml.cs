using System;
using System.Windows;
using DataAccess;
using GUI.ViewModels;

namespace GUI
{
    /// <summary>
    /// Interaction logic for PaymentWindow.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {
        public MainWindow MainWindow;
        public PaymentWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            MainWindow = mainWindow;
        }

        private void Pay_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (radioButtonCard.IsChecked == false && radioButtonCash.IsChecked == false)
                {
                    throw new UnselectedPaymentMethodError();
                }
                if (radioButtonCard.IsChecked == true)
                {
                    CurrentOrder.PaymentType = PaymentType.Card;
                }
                else if (radioButtonCash.IsChecked == true)
                {
                    CurrentOrder.PaymentType = PaymentType.Cash;
                }
                Order order = new Order();
                order.Products.Sort();
                order.SaveXML(DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss"));
                MessageBox.Show("Your payment has been accepted!", "Success!");
                CurrentOrder.ClearCurrentOrder();
                MainWindow.UpdateCurrentAmmount();
                MainWindow.UpdateNumberOfItems();
                MainWindow.ClearBasketButton.IsEnabled = false;
                MainWindow.ViewOrderButton.IsEnabled = false;
                Close();
                MainWindow.ButtonBurgers_Click(this, null);
            }
            catch(UnselectedPaymentMethodError)
            {
                MessageBox.Show("Choose payment method!", "", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BackToOrderViewButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}