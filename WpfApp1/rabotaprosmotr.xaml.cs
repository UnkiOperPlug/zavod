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
using System.Data;
using System.Data.SqlClient;
namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для rabotaprosmotr.xaml
    /// </summary>
    public partial class rabotaprosmotr : Window
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-CJ7TL6O;Initial Catalog=barbariska;Integrated Security=True");
        //PUBLIC бывает публичное и приватное. публичное можно вызывать в других кодах, а приватное нельзя вызывать в других кодах
        //VOID не возвращает значение из функции. в случае если нужно вернуть значение пишем тип данных вместо воид

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) // если подключение закрыто
            {
                sqlConnection.Open();// открываем подключение
            }
        }

        public void closedConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }

        private void ski_click(object sender, RoutedEventArgs e)
        {

            try
            {
                sqlConnection.Open();
                string Query = "select name,kolichestvo,ediniciizmereniya,cena from shokolad ";
                SqlCommand createCommand = new SqlCommand(Query, sqlConnection);
                createCommand.ExecuteNonQuery();

                SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                DataTable dt = new DataTable("shokolad");
                dataAdp.Fill(dt);
                DgridZavod.ItemsSource = dt.DefaultView;
                dataAdp.Update(dt);
                sqlConnection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public rabotaprosmotr()
        {
            InitializeComponent();
        }

        private void DgridZavod_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void poisk_click(object sender, RoutedEventArgs e)
        {
            rabotapoisk ll = new rabotapoisk();
            ll.Show();
        }

        private void vernutsya_click(object sender, RoutedEventArgs e)
        {
            MainWindow og = new MainWindow();
            og.Show();
            this.Close();
        }

        private void izmenit_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Что хотите изменить?");
        }
    }


}
