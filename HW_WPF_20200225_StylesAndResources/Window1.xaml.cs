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

namespace HW_WPF_20200225_StylesAndResources
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            this.Closing += OpenMainWIndow;
        }

        private void OpenMainWIndow(object sender, EventArgs e)
        {
            //MessageBox.Show("Окно закрыто");
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
