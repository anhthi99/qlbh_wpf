using QLBH_WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
//using QLBH_WPF
using QLBH_WPF.Logics;
using System.Collections.ObjectModel;
using common.Logics;

namespace QLBH_WPF.ViewModels
{
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string ProducerID { get; set; }
        public string ProducerName { get; set; }
        public Product()
        {

        }
    }
    public class MainWindowViewModel : ViewModelBase
    {
        public ICommand GetSession { get; set; }
        public ICommand LoadedWindow { get; set; }
        public string Message { get; set; }
        public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>
        {
            new Product(){ID="1", Name="Sản phẩm 1", Price="2.555", ProducerName="dsadsa"},
            new Product(){ID="1", Name="Sản phẩm 2", Price="5555", ProducerName="Mô tả"},
        };
        public List<Users> Users { get; set; }
        public MainWindowViewModel()
        {
            //GetSession = new MainWindowCommand(ShowMessage);
            //ShowLogin();
            LoadedWindow = new MainWindowCommand<Window>((p) => true, ShowLogin);
            Users = DataProvider.Instance.Data.Users.ToList();
        }

        void ShowLogin(Window w)
        {
            w.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        void ShowMessage()
        {
            //Users user = DataProvider.entity.Users.Take(1).ToList()[0];
            //MessageBox.Show(Helper.ConvertToMD5("admin"));
        }
        void ButtonOnClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
