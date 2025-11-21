using Microsoft.Win32;
using System.IO;
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

namespace _2025_11_21_P1
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

        private void New_File(object sender, RoutedEventArgs e)
        {
            FileStream f = new FileStream("proba.txt", FileMode.Create);
            f.Close();
        }

        private void Open_File(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opendialog = new OpenFileDialog();
            opendialog.ShowDialog();
            textBox.Text = File.ReadAllText(opendialog.FileName);
        }

        private void Save_File(object sender, RoutedEventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.ShowDialog();
            File.WriteAllText(savedialog.FileName, textBox.Text, Encoding.UTF8);
        }

        private void Exit_Button(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}