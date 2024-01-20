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
    /// Логика взаимодействия для adminvivod.xaml
    /// </summary>
    public partial class adminvivod : Window
    {
        Class1 class1 = new Class1();

        public adminvivod()
            {
            InitializeComponent();
            
            
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-CJ7TL6O;Initial Catalog=barbariska;Integrated Security=True");

                connection.Open();
                string cmd = "SELECT * FROM shokolad"; // Из какой таблицы нужен вывод 
                SqlCommand createCommand = new SqlCommand(cmd, connection);
                createCommand.ExecuteNonQuery();

                SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                System.Data.DataTable dt = new System.Data.DataTable("shokolad"); // В скобках указываем название таблицы
                dataAdp.Fill(dt);
                DgridZavod.ItemsSource = dt.DefaultView; // Сам вывод 
                connection.Close();
                
            

        }
        


        private void vernutsya_click(object sender, RoutedEventArgs e)
        {
            
        }

        private void DgridZavod_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dobavlenie_click_1(object sender, RoutedEventArgs e)
        {
            admindobavlenie o = new admindobavlenie();
            o.Show();
            this.Close();
        }

        private void udalenie_click_1(object sender, RoutedEventArgs e)
        {
            adminudalenie l = new adminudalenie();
            l.Show();
            this.Close();
        }

        private void poisk_Click_1(object sender, RoutedEventArgs e)
        {
            adminpoisk p = new adminpoisk();
            p.Show();
            this.Close();
        }

        private void vernutsya_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow og = new MainWindow();
            og.Show();
            this.Close();
        }

        private void izmenit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Что хотите изменить?");        }
    }
}
