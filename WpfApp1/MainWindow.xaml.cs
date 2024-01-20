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
using System.Data.SqlClient;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Class1 class1 = new Class1();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void vxod_Click(object sender, RoutedEventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            System.Data.DataTable table1 = new System.Data.DataTable();

            var log = login.Text;
            var pass = password.Text;
            var roll = role.Text;
            string querystring = $"select password,login,role from konfeta where login = '{log}' and password = '{pass}' and role = '{roll}' ";
            string wlk = $"INSERT INTO [dbo].[konfeta] VALUES ('{log}', '{pass}', '{roll}')";
            SqlCommand command2 = new SqlCommand(wlk, class1.getConnection());
            adapter.SelectCommand = command2;
            adapter.Fill(table1);
            SqlCommand command = new SqlCommand(querystring, class1.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table1);

            if (table1.Rows.Count == 1)
            {
                if (role.Text == "работник")
                {
                    rabotaprosmotr ll = new rabotaprosmotr();
                    ll.Show();
                    this.Close();
                }
                if (role.Text == "админ")
                {
                    adminvivod s = new adminvivod();
                    s.Show();
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("неверные данные");
                
            }



        }

        private void x_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rabotaprosmotr i = new rabotaprosmotr();
            i.Show();
            this.Close();
        }

        private void role_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            registraciya tt = new registraciya();
            tt.Show();
            this.Close();
        }
    }
}
