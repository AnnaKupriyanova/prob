using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для AddEdit.xaml
    /// </summary>
    public partial class AddEdit : Window
    {
        ApplicationContext db;
        public AddEdit()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string last_name = input_last_name.Text.Trim();
            string first_name = input_first_name.Text.Trim();
            string middle_name = input_middle_name.Text.Trim();
            string degree = input_degree.Text.Trim();
            string position = input_position.Text.Trim();
            string exp = input_exp.Text.Trim();
            

            input_last_name.ToolTip = "";
            input_last_name.Background = Brushes.Transparent;
            input_first_name.ToolTip = "";
            input_first_name.Background = Brushes.Transparent;
            input_middle_name.ToolTip = "";
            input_middle_name.Background = Brushes.Transparent;
            input_degree.ToolTip = "";
            input_degree.Background = Brushes.Transparent;
            input_position.ToolTip = "";
            input_position.Background = Brushes.Transparent;
            input_exp.ToolTip = "";
            input_exp.Background = Brushes.Transparent;

            if (input_last_name.Text == "" || input_first_name.Text == "" || input_middle_name.Text == "" || input_position.Text == "" || input_exp.Text == "" || input_degree.Text == "")
            {
                MessageBox.Show("Заполните поля", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
            } else
            {
                if (!Regex.Match(input_last_name.Text, "^[А-Я][а-яА-я]*$").Success)
                {
                    MessageBox.Show("Введите корректную фамилию", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
                    input_last_name.Focus();
                    return;
                }
                if (!Regex.Match(input_first_name.Text, "^[А-Я][а-яА-я]*$").Success)
                {
                    MessageBox.Show("Введите корректное имя", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
                    input_first_name.Focus();
                    return;
                }
                if (!Regex.Match(input_middle_name.Text, "^[А-Я][а-яА-я]*$").Success)
                {
                    MessageBox.Show("Введите корректное отчество", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
                    input_middle_name.Focus();
                    return;
                }
                if (!Regex.Match(input_position.Text, "^[А-Я][а-яА-я]*$").Success)
                {
                    MessageBox.Show("Введите корректную должность", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
                    input_position.Focus();
                    return;
                }
                if (!Regex.Match(input_exp.Text, "^[0-9]*$").Success)
                {
                    MessageBox.Show("Введите корректный стаж", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
                    input_exp.Focus();
                    return;
                }
                if (Int32.Parse(input_exp.Text) > 90)
                {
                    MessageBox.Show("Введите корректный стаж", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
                    input_exp.Focus();
                    return;
                }

                Teacher teacher = new Teacher(last_name, first_name, middle_name, degree, position, exp);

                db.Teachers.Add(teacher);
                db.SaveChanges();

                input_last_name.Clear();
                input_first_name.Clear();
                input_middle_name.Clear();
                input_position.Clear();
                input_exp.Clear();
            }
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            Inf_system inf_System = new Inf_system();
            inf_System.Show();
            this.Hide();
        }
    }
}
