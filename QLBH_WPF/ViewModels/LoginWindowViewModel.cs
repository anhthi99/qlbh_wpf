using QLBH_WPF.Logics;
using QLBH_WPF.Models;
using QLBH_WPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QLBH_WPF.ViewModels
{
    public class LoginWindowViewModel : ViewModelBase
    {
        public ICommand OpenTestForm { get; set; }
        public ICommand PasswordChangedCommand { get; set; }
        public ICommand LoginProcessCommand { get; set; }
        public ICommand CloseLoginCommand { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        public LoginWindowViewModel()
        {
            //OnPropertyChanged()
            OpenTestForm = new LoginWindowCommand(c => true, () => { TestForm tf = new TestForm(); tf.ShowDialog(); });
            PasswordChangedCommand = new LoginWindowCommand(c => true, p => Password = p.Password);
            LoginProcessCommand = new LoginWindowCommand(c => true, LoginProcessing);
            CloseLoginCommand = new LoginWindowCommand(c => true, w => w.Close());
        }

        private void LoginProcessing(Window w)
        {
            Users user = DataProvider.Instance.Data.Users.FirstOrDefault((u) => u.UserName == this.UserName && u.Password == this.Password);
            if(user != null)
            {
                TestForm tf = new TestForm();
                tf.ShowDialog();
                w.Hide();
            }
            else
            {
                MessageBox.Show("Thông tin tài khoản không đúng. Vui lòng nhập lại", "Lỗi đăng nhập", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void CloseProcessing(Window w)
        {
            w.Close();
        }

    }
}
