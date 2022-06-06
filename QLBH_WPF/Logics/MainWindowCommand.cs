using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QLBH_WPF.Logics
{
    public class MainWindowCommand<T> : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public Predicate<bool> _can;
        private readonly Action<T> _exe;

        public MainWindowCommand(Predicate<bool> can, Action<T> c)
        {
            _can = can;
            _exe = c;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _exe((T)parameter);
        }
    }
}
