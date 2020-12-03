using MySql.Data.MySqlClient;
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

namespace DataCar
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            string connection_info= "server=localhost;user=root;database=data;password=1234";

            MySqlConnection connection = new MySqlConnection(connection_info);


            MySqlCommand command = new MySqlCommand();

            connection.Open();


            connection.Close();



        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {




        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
           
        }

        



        private void Button_Click(object sender, RoutedEventArgs e)
        {

            

            





        }
    }
}
