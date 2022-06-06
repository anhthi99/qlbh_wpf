using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QLBH_WPF.Logics
{
    public class LoginWindowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Predicate<bool> _canexe;
        private Action _exe;
        private Action<PasswordBox> _exe2;
        private Action<Window> _exe3;
        public LoginWindowCommand(Predicate<bool> _c, Action _e)
        {
            _canexe = _c;
            _exe = _e;
        }

        public LoginWindowCommand(Predicate<bool> _c, Action<PasswordBox> _e)
        {
            _canexe = _c;
            _exe2 = _e;
        }

        public LoginWindowCommand(Predicate<bool> _c, Action<Window> _e)
        {
            _canexe = _c;
            _exe3 = _e;
        }

        public bool CanExecute(object parameter)
        {
            return _canexe(true);
        }

        public void Execute(object parameter)
        {
            if(parameter != null)
            {
                if(parameter is PasswordBox)
                {
                    _exe2((PasswordBox)parameter);
                }
                else if(parameter is Window)
                {
                    _exe3((Window)parameter);
                }
                else
                {

                }
            }
            else
            {
                _exe();
            }
        }
    }
}
