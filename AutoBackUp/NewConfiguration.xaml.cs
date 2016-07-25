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
using System.Windows.Shapes;

namespace AutoBackUp
{
    /// <summary>
    /// Interaction logic for NewConfiguration.xaml
    /// </summary>
    public partial class NewConfiguration : Window
    {
        public NewConfiguration()
        {
            InitializeComponent();
        }

        private void btn_add_folder_Click(object sender, RoutedEventArgs e)
        {
            AddFolder newFolderConfig = new AddFolder();
            newFolderConfig.ShowDialog();
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
