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
using System.Windows.Shapes;
using WpfApp1.Data;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для AddOrders.xaml
    /// </summary>
    public partial class AddOrders : Window
    {
        ApplicationContext context;
        public List<Orders> _orders;
        public AddOrders()
        {
            InitializeComponent();
            context = new ApplicationContext();

            
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {

            _orders = new() {
                new Orders {
                    numberOfOrder = Convert.ToInt32(numberOfOrder.Text),
                    typeOfGoods = typeOfGoods.Text,
                    weightOne = Convert.ToInt32(weightOne.Text),
                    volumeOfUnit = Convert.ToInt32(volumeOfUnit.Text),
                    distance = distance.Text,
                    quantity = Convert.ToInt32(quantity.Text),
                    name = name.Text,
                    phoneNumber = phoneNumber.Text,
                    
                }
            };
            context.orders.AddRange(_orders);
            context.SaveChanges();
            DialogResult = true;
        }
      
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
