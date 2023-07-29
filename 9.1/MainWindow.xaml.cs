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

namespace _9._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
            foreach(string s in textBox1.Text.Split(' '))
            {
                listBox1.Items.Add(s);
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "";
            string[] s = textBox2.Text.Split(" ");
            for(int i = s.Length - 1; i >= 0; i--)
            {
                label1.Content += s[i] + ' ';
            }
        }
    }
}
