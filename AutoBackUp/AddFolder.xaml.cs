using AutoBackUp.Models;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace AutoBackUp
{
    /// <summary>
    /// Interaction logic for AddFolder.xaml
    /// </summary>
    public partial class AddFolder : Window
    {
        public FolderPair Result { get; set; }

        public AddFolder()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txt_source_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_source.Text) || string.IsNullOrWhiteSpace(txt_dest.Text))
                btn_ok.IsEnabled = false;
            else
                btn_ok.IsEnabled = true;
        }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            if (Directory.Exists(txt_dest.Text) && Directory.Exists(txt_source.Text))
            {
                FolderPair folderPair = new FolderPair();
                folderPair.Destination = txt_dest.Text;
                folderPair.Source = txt_source.Text;
                //
                Result = folderPair;
                //
                this.Close();
            }
            else
                MessageBox.Show("Sorry one or both paths entered do not exist", "Invalid Paths", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void btn_browse_source_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txt_source.Text = fbd.SelectedPath;
        }

        private void btn_browse_dest_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txt_dest.Text = fbd.SelectedPath;
        }
    }
}
