//Rafael Rivera Harrison

// 04/08/2024

//Lecture notes week 2 github
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lecture_notes_week_2_github
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Rafael Rivera
        //04.08.24
        public MainWindow()
        {
            InitializeComponent();

           string userFirstName=txtFirstName.Text;

            //Message box
            //MessageBox.Show(userFirstName);

            //btnPopupmessage.Content = "Hello mochi";

            //hello i like food
        }

        private void btnPopupmessage_Click(object sender, RoutedEventArgs e)
        {

            int a = 6;

                int b = 7;

                int sum = a + b;



            string userFirstName = txtFirstName.Text;

            MessageBox.Show(userFirstName);

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void buttonAddNumbers_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(TextNumber_1.Text);

            int b = int.Parse(TextNumber_2.Text);

            int sum = a + b;

            MessageBox.Show(sum.ToString());
        }
    }
}