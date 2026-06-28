namespace HotelApp.Forms
{
    partial class HistoryForm
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
            this.hotelDataSet = new HotelApp.hotelDataSet();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historyTableAdapter = new HotelApp.hotelDataSetTableAdapters.HistoryTableAdapter();
            this.tableAdapterManager = new HotelApp.hotelDataSetTableAdapters.TableAdapterManager();
            this.historyDataGridView = new System.Windows.Forms.DataGridView();
            this.HotelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOutColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitleAttentionFont
            // 
            this.labelTitleAttentionFont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(100)))), ((int)(((byte)(254)))));
            // 
            // buttonBackAdditionalFontAttentionBack
            // 
            this.buttonBackAdditionalFontAttentionBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(100)))), ((int)(((byte)(254)))));
            this.buttonBackAdditionalFontAttentionBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(254)))), ((int)(((byte)(57)))));
            this.buttonBackAdditionalFontAttentionBack.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.historyDataGridView);
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "hotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historyTableAdapter
            // 
            this.historyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.GuestTableAdapter = null;
            this.tableAdapterManager.HistoryTableAdapter = this.historyTableAdapter;
            this.tableAdapterManager.HotelTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.RoomTypeTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelApp.hotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // historyDataGridView
            // 
            this.historyDataGridView.AllowUserToAddRows = false;
            this.historyDataGridView.AllowUserToDeleteRows = false;
            this.historyDataGridView.AutoGenerateColumns = false;
            this.historyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HotelColumn,
            this.CheckInColumn,
            this.CheckOutColumn,
            this.RoomNumberColumn,
            this.CommentColumn});
            this.historyDataGridView.DataSource = this.historyBindingSource;
            this.historyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyDataGridView.Location = new System.Drawing.Point(0, 0);
            this.historyDataGridView.Name = "historyDataGridView";
            this.historyDataGridView.ReadOnly = true;
            this.historyDataGridView.Size = new System.Drawing.Size(800, 346);
            this.historyDataGridView.TabIndex = 0;
            // 
            // HotelColumn
            // 
            this.HotelColumn.DataPropertyName = "HotelName";
            this.HotelColumn.HeaderText = "Отель";
            this.HotelColumn.Name = "HotelColumn";
            this.HotelColumn.ReadOnly = true;
            // 
            // CheckInColumn
            // 
            this.CheckInColumn.DataPropertyName = "CheckIn";
            this.CheckInColumn.HeaderText = "Время заселения";
            this.CheckInColumn.Name = "CheckInColumn";
            this.CheckInColumn.ReadOnly = true;
            // 
            // CheckOutColumn
            // 
            this.CheckOutColumn.DataPropertyName = "CheckOut";
            this.CheckOutColumn.HeaderText = "Время выезда";
            this.CheckOutColumn.Name = "CheckOutColumn";
            this.CheckOutColumn.ReadOnly = true;
            // 
            // RoomNumberColumn
            // 
            this.RoomNumberColumn.DataPropertyName = "RoomNumber";
            this.RoomNumberColumn.HeaderText = "Номер комнаты";
            this.RoomNumberColumn.Name = "RoomNumberColumn";
            this.RoomNumberColumn.ReadOnly = true;
            // 
            // CommentColumn
            // 
            this.CommentColumn.DataPropertyName = "Comment";
            this.CommentColumn.HeaderText = "Комментарий";
            this.CommentColumn.Name = "CommentColumn";
            this.CommentColumn.ReadOnly = true;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private hotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private hotelDataSetTableAdapters.HistoryTableAdapter historyTableAdapter;
        private hotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView historyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOutColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentColumn;
    }
}