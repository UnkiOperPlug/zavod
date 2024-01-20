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
using System.Data.SqlClient;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для registraciya.xaml
    /// </summary>
    public partial class registraciya : Window
    {
        Class1 class1 = new Class1();
        public registraciya()
        {
            InitializeComponent();
        }

        private void zareg_Click(object sender, RoutedEventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            System.Data.DataTable table1 = new System.Data.DataTable();

            var log1 = login.Text;
            var pass1 = password.Text;
            var roll1 = role.Text;

            string wlk = $"INSERT INTO [dbo].[konfeta] VALUES ('{log1}', '{pass1}', '{roll1}')";
            SqlCommand command2 = new SqlCommand(wlk, class1.getConnection());
            adapter.SelectCommand = command2;
            adapter.Fill(table1);

            MessageBox.Show("Вы успешно вошли");
        }

        private void role_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void x_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
