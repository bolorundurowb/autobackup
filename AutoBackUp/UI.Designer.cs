namespace AutoBackUp
{
    partial class UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgv_devices = new System.Windows.Forms.DataGridView();
            this.devices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_folder_details = new System.Windows.Forms.DataGridView();
            this.folderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folderPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backupFolderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_auto_backup = new System.Windows.Forms.CheckBox();
            this.txt_backup_folder_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_folder_path = new System.Windows.Forms.Label();
            this.btn_select_folder = new System.Windows.Forms.Button();
            this.fbd_get_folder = new System.Windows.Forms.FolderBrowserDialog();
            this.cms_dgv_folders = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.remooveRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_devices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_folder_details)).BeginInit();
            this.cms_dgv_folders.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgv_devices);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_save);
            this.splitContainer1.Panel2.Controls.Add(this.dgv_folder_details);
            this.splitContainer1.Panel2.Controls.Add(this.chk_auto_backup);
            this.splitContainer1.Panel2.Controls.Add(this.txt_backup_folder_name);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_folder_path);
            this.splitContainer1.Panel2.Controls.Add(this.btn_select_folder);
            this.splitContainer1.Panel2.Enabled = false;
            this.splitContainer1.Panel2MinSize = 400;
            this.splitContainer1.Size = new System.Drawing.Size(884, 511);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgv_devices
            // 
            this.dgv_devices.AllowUserToAddRows = false;
            this.dgv_devices.AllowUserToDeleteRows = false;
            this.dgv_devices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_devices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_devices.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_devices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_devices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_devices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.devices});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_devices.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_devices.Location = new System.Drawing.Point(12, 12);
            this.dgv_devices.Name = "dgv_devices";
            this.dgv_devices.ReadOnly = true;
            this.dgv_devices.RowHeadersVisible = false;
            this.dgv_devices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_devices.Size = new System.Drawing.Size(226, 487);
            this.dgv_devices.TabIndex = 0;
            this.dgv_devices.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_devices_CellMouseClick);
            // 
            // devices
            // 
            this.devices.HeaderText = "Devices";
            this.devices.Name = "devices";
            this.devices.ReadOnly = true;
            // 
            // btn_save
            // 
            this.btn_save.Image = global::AutoBackUp.Properties.Resources._4;
            this.btn_save.Location = new System.Drawing.Point(543, 481);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_folder_details
            // 
            this.dgv_folder_details.AllowUserToAddRows = false;
            this.dgv_folder_details.AllowUserToDeleteRows = false;
            this.dgv_folder_details.AllowUserToOrderColumns = true;
            this.dgv_folder_details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_folder_details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_folder_details.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_folder_details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_folder_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_folder_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folderName,
            this.folderPath,
            this.backupFolderName});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_folder_details.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_folder_details.Location = new System.Drawing.Point(13, 78);
            this.dgv_folder_details.MultiSelect = false;
            this.dgv_folder_details.Name = "dgv_folder_details";
            this.dgv_folder_details.ReadOnly = true;
            this.dgv_folder_details.RowHeadersVisible = false;
            this.dgv_folder_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_folder_details.Size = new System.Drawing.Size(605, 397);
            this.dgv_folder_details.TabIndex = 5;
            // 
            // folderName
            // 
            this.folderName.HeaderText = "Folder Name";
            this.folderName.Name = "folderName";
            this.folderName.ReadOnly = true;
            // 
            // folderPath
            // 
            this.folderPath.HeaderText = "Folder Path";
            this.folderPath.Name = "folderPath";
            this.folderPath.ReadOnly = true;
            // 
            // backupFolderName
            // 
            this.backupFolderName.HeaderText = "BackUp Folder Name";
            this.backupFolderName.Name = "backupFolderName";
            this.backupFolderName.ReadOnly = true;
            // 
            // chk_auto_backup
            // 
            this.chk_auto_backup.AutoSize = true;
            this.chk_auto_backup.Location = new System.Drawing.Point(13, 50);
            this.chk_auto_backup.Name = "chk_auto_backup";
            this.chk_auto_backup.Size = new System.Drawing.Size(368, 17);
            this.chk_auto_backup.TabIndex = 4;
            this.chk_auto_backup.Text = "Automatically back folders up when device associated device detected?";
            this.chk_auto_backup.UseVisualStyleBackColor = true;
            this.chk_auto_backup.CheckedChanged += new System.EventHandler(this.chk_auto_backup_CheckedChanged);
            // 
            // txt_backup_folder_name
            // 
            this.txt_backup_folder_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_backup_folder_name.Location = new System.Drawing.Point(490, 12);
            this.txt_backup_folder_name.Name = "txt_backup_folder_name";
            this.txt_backup_folder_name.Size = new System.Drawing.Size(128, 20);
            this.txt_backup_folder_name.TabIndex = 3;
            this.txt_backup_folder_name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_backup_folder_name_KeyUp);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Backup Folder Name:";
            // 
            // lbl_folder_path
            // 
            this.lbl_folder_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_folder_path.AutoSize = true;
            this.lbl_folder_path.Location = new System.Drawing.Point(103, 17);
            this.lbl_folder_path.Name = "lbl_folder_path";
            this.lbl_folder_path.Size = new System.Drawing.Size(0, 13);
            this.lbl_folder_path.TabIndex = 1;
            // 
            // btn_select_folder
            // 
            this.btn_select_folder.Location = new System.Drawing.Point(13, 12);
            this.btn_select_folder.Name = "btn_select_folder";
            this.btn_select_folder.Size = new System.Drawing.Size(75, 23);
            this.btn_select_folder.TabIndex = 0;
            this.btn_select_folder.Text = "Browse...";
            this.btn_select_folder.UseVisualStyleBackColor = true;
            this.btn_select_folder.Click += new System.EventHandler(this.btn_select_folder_Click);
            // 
            // fbd_get_folder
            // 
            this.fbd_get_folder.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // cms_dgv_folders
            // 
            this.cms_dgv_folders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remooveRowToolStripMenuItem});
            this.cms_dgv_folders.Name = "cms_dgv_folders";
            this.cms_dgv_folders.Size = new System.Drawing.Size(144, 26);
            // 
            // remooveRowToolStripMenuItem
            // 
            this.remooveRowToolStripMenuItem.Name = "remooveRowToolStripMenuItem";
            this.remooveRowToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.remooveRowToolStripMenuItem.Text = "Remove Row";
            this.remooveRowToolStripMenuItem.Click += new System.EventHandler(this.remooveRowToolStripMenuItem_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTO BACKUP";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_devices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_folder_details)).EndInit();
            this.cms_dgv_folders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgv_devices;
        private System.Windows.Forms.DataGridView dgv_folder_details;
        private System.Windows.Forms.CheckBox chk_auto_backup;
        private System.Windows.Forms.TextBox txt_backup_folder_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_folder_path;
        private System.Windows.Forms.Button btn_select_folder;
        private System.Windows.Forms.DataGridViewTextBoxColumn devices;
        private System.Windows.Forms.DataGridViewTextBoxColumn folderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn folderPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn backupFolderName;
        private System.Windows.Forms.FolderBrowserDialog fbd_get_folder;
        private System.Windows.Forms.ContextMenuStrip cms_dgv_folders;
        private System.Windows.Forms.ToolStripMenuItem remooveRowToolStripMenuItem;
        private System.Windows.Forms.Button btn_save;
    }
}

