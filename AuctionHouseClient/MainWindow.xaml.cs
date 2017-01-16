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
using AuctionHouseClient.AuctionHouseServiceReference;

namespace AuctionHouseClient
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

        private void GetAllProductsBtn_Click(object sender, RoutedEventArgs e)
        {
            Controller c = new Controller();
            ProductGrid.AutoGenerateColumns = true;
            ProductGrid.ItemsSource = c.GetAllProducts();
        }

        private void GetProductBtn_Click(object sender, RoutedEventArgs e)
        {
            Controller c = new Controller();
            List<Product> pl = new List<Product>();
            Product p = c.GetProduct(ItemNumberTbx.Text);
            pl.Add(p);

            ProductGrid.AutoGenerateColumns = true;
            ProductGrid.ItemsSource = pl;
        }

        private void PlaceBidBtn_Click(object sender, RoutedEventArgs e)
        {
            Controller c = new Controller();
            c.BidOnProduct(BidItemNumberTbx.Text, BidPriceTbx.Text, CustomNameTbx.Text, CustomPhoneTbx.Text);
        }
    }
}
