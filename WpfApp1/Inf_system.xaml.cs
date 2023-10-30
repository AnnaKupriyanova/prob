using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Inf_system.xaml
    /// </summary>
    public partial class Inf_system : Window
    {
        ApplicationContext db;

        public Inf_system()
        {
            InitializeComponent();
            db = new ApplicationContext();
            List<Teacher> teachers = db.Teachers.ToList();

            list_teachers.ItemsSource = teachers;
        }

        private void Delete_Button(object sender, RoutedEventArgs e)
        {
            db.Teachers.Remove(list_teachers.SelectedItem as Teacher);
            db.SaveChanges();

            List<Teacher> teachers = db.Teachers.ToList();

            list_teachers.ItemsSource = teachers;
            list_teachers.Items.Refresh();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddEdit addEdit = new AddEdit();
            addEdit.Show();
            this.Hide();

            List<Teacher> teachers = db.Teachers.ToList();

            list_teachers.ItemsSource = teachers;
            list_teachers.Items.Refresh();
        }
    }
}
