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

namespace common.Controls
{
    /// <summary>
    /// Interaction logic for ButtonCustom.xaml
    /// </summary>
    public partial class UCButton : UserControl
    {
        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }
        public static DependencyProperty LabelProperty = DependencyProperty.Register("Label", typeof(string), typeof(UCButton));

        public UCButton()
        {
            InitializeComponent();
        }
        
    }
}
