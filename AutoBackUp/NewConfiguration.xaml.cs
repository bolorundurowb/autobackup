using AutoBackUp.Models;
using System.Windows;
using System.Windows.Data;

namespace AutoBackUp
{
    /// <summary>
    /// Interaction logic for NewConfiguration.xaml
    /// </summary>
    public partial class NewConfiguration : Window
    {
        public NewConfiguration()
        {
            InitializeComponent(); Models.USBDeviceInfo.GetAllUSBDevices();
            //
            sourceFolder.Binding = new Binding("SourcePath");
            destinationFolder.Binding = new Binding("DestinationPath");
        }

        private void btn_add_folder_Click(object sender, RoutedEventArgs e)
        {
            AddFolder newFolderConfig = new AddFolder();
            newFolderConfig.ShowDialog();
            //
            FolderPair folderPair = new FolderPair();
            folderPair = newFolderConfig.Result;
            //
            dgv_folder_pairs.Items.Add(new TableData { SourcePath = folderPair.Source, DestinationPath = folderPair.Destination });
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void lst_connected_devices_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (lst_connected_devices.SelectedItems.Count != 0)
                btn_add_folder.IsEnabled = true;
            else
                btn_add_folder.IsEnabled = false;
        }

        private void dgv_folder_pairs_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (dgv_folder_pairs.SelectedItems.Count > 0)
                btn_remove_folder.IsEnabled = true;
            else
                btn_remove_folder.IsEnabled = false;
        }

        private void btn_remove_folder_Click(object sender, RoutedEventArgs e)
        {
            var row = dgv_folder_pairs.SelectedItem;
            //
            dgv_folder_pairs.Items.Remove(row);
        }
    }

    public struct TableData
    {
        public string SourcePath { get; set; }
        public string DestinationPath { get; set; }
    }
}
