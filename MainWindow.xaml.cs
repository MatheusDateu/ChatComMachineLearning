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

namespace ChatML
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

        private void btn_Acess(object sender, RoutedEventArgs e)
        {
            string userName = txt_Username.Text;
            string passWord = stxt_Password.Password.ToString();

            if(userName != "Admin" || passWord != "1234")
                MessageBox.Show("Senha incorreta", "Oops");
            else
                Application.Current.Shutdown();
        }
    }
}
