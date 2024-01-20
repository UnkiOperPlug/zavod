using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WpfApp1
{
    class Class1
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

    }
}

  
