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

namespace WpfApp1
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

        private void Card_Button_Click(object sender, RoutedEventArgs e)
        {
            Card card = new Card();
            card.Show();
        }

        private void Tables_Button_Click(object sender, RoutedEventArgs e)
        {
            Table table = new Table();
            table.Show();

        }

        private void Form_Button_Click(object sender, RoutedEventArgs e)
        {
            Form form = new Form();
            form.Show();
        }

        private void IS_Button_Click(object sender, RoutedEventArgs e)
        {
            Inf_system inf_System = new Inf_system();
            inf_System.Show();
        }

        private void Diagram_Button_Click(object sender, RoutedEventArgs e)
        {
            DiaImg img = new DiaImg();
            img.Show();
        }
    }
}
