using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using System.Diagnostics;

namespace AutoBackUp
{
    public partial class UI : Form
    {
        SQLiteConnection connection;
        public UI()
        {
            InitializeComponent();
            string connectionString = "URI=file:DataStore.db";
            connection = new SQLiteConnection(connectionString);
        }

        private void btn_select_folder_Click(object sender, EventArgs e)
        {
            fbd_get_folder.ShowDialog();
            lbl_folder_path.Text = fbd_get_folder.SelectedPath;
            txt_backup_folder_name.Focus();
        }

        private void txt_backup_folder_name_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txt_backup_folder_name.Text) || string.IsNullOrWhiteSpace(lbl_folder_path.Text))
                    MessageBox.Show("An error occured adding.\n\nPlease select a folder to backup, and specify a backup name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    DialogResult result = System.Windows.Forms.DialogResult.None;
                    DataGridViewRow temp = new DataGridViewRow();
                    foreach (DataGridViewRow row in dgv_folder_details.Rows)
                        if (row.Cells[1].Value.ToString() == lbl_folder_path.Text)
                        {
                            result = MessageBox.Show("The specified folder has been added previously, do you want to replace it?\nIf you choose 'YES' the data would be replaced, if you select 'NO' the data would be retained but you can still modify the backup folder name in the table.", "Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            temp = row;
                        }
                    if (result == DialogResult.None)
                    {
                        dgv_folder_details.Rows.Add(Path.GetFileNameWithoutExtension(lbl_folder_path.Text), lbl_folder_path.Text, txt_backup_folder_name.Text);
                        lbl_folder_path.Text = "";
                        txt_backup_folder_name.Clear();
                    }
                    else if (result == DialogResult.Yes)
                    {
                        dgv_folder_details.Rows.Remove(temp);
                        dgv_folder_details.Rows.Add(Path.GetFileNameWithoutExtension(lbl_folder_path.Text), lbl_folder_path.Text, txt_backup_folder_name.Text);
                        lbl_folder_path.Text = "";
                        txt_backup_folder_name.Clear();
                    }
                }
            }
        }

        private void remooveRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_folder_details.Rows[dgv_folder_details.SelectedCells[0].RowIndex].Selected = true;
            DialogResult result = MessageBox.Show("Do you want to remove the selected entry?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                dgv_folder_details.Rows.RemoveAt(dgv_folder_details.SelectedCells[0].RowIndex);
        }

        private void chk_auto_backup_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand("DROP TABLE IF EXISTS " + dgv_devices.SelectedRows[0].Cells[0].Value.ToString(), connection);
            try
            {
                cmd.ExecuteNonQuery();
                cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS " + dgv_devices.SelectedRows[0].Cells[0].Value.ToString() + " (FolderName NVARCHAR(100), FolderPath NVARCHAR(300), BackUp NVARCHAR(100))", connection);
                cmd.ExecuteNonQuery();
                foreach (DataGridViewRow row in dgv_folder_details.Rows)
                {
                    cmd = new SQLiteCommand("INSERT OR REPLACE INTO FolderData (FolderName, FolderPath, BackUp) VALUES ('" + row.Cells[0].Value.ToString() + "','" + row.Cells[1].Value.ToString() + "','" + row.Cells[2].Value.ToString() + "')", connection);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Congratulations, the databse has been update successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SQLiteException ex)
            {
                Debug.Write("An error occured: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dgv_devices_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM " + dgv_devices.SelectedRows[0].Cells[0].Value.ToString(), connection);
            try
            {
                SQLiteDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    dgv_folder_details.Rows.Add(reader["FolderName"], reader["FolderPath"], reader["BackUp"]);
                }
            }
            catch(SQLiteException ex)
            {
                Debug.Write("An error occured: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
