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
using FitnessAssistant_Nikitin_Liventsev2ISP11_17.Windows;
using FitnessAssistant_Nikitin_Liventsev2ISP11_17.Properties;
using FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes;
using FitnessAssistant_Nikitin_Liventsev2ISP11_17.DataBase;

namespace FitnessAssistant_Nikitin_Liventsev2ISP11_17
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            // Проверка на пустоту 
            if (string.IsNullOrWhiteSpace(Login.Text))
            {
                MessageBox.Show("Логин должен быть заполнен");
                return;
            }

            if (string.IsNullOrWhiteSpace(Password.Text))
            {
                MessageBox.Show("Пароль должнен быть заполнен");
                return;
            }

            var userAuth = AppData.Context.User.ToList().
            Where(i => i.Login == Login.Text && i.Password == Password.Text).
            FirstOrDefault();
            if (userAuth != null)
            {
                Results results = new Results (userAuth);
                results.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Пользователь с такими данными не найден!");
            }
        }
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow openwindow = new RegistrationWindow();
            openwindow.Show();
            this.Close();
        }
    }
}
