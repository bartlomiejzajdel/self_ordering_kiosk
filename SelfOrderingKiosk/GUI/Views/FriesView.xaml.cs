using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataAccess;

namespace GUI.Views
{
    /// <summary>
    /// Interaction logic for FriesView.xaml
    /// </summary>
    public partial class FriesView : UserControl
    {
        public FriesView()
        {
            InitializeComponent();
        }

        private void AddToOrder_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            CurrentOrder.AddToOrder((Product)button.DataContext);
            MainWindow win = (MainWindow)Window.GetWindow(this);
            win.UpdateCurrentAmmount();
            CurrentOrder.NumberOfItems++;
            win.UpdateNumberOfItems();
            win.ClearBasketButton.IsEnabled = true;
            win.ViewOrderButton.IsEnabled = true;
        }
    }
}
