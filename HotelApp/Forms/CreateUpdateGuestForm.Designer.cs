namespace HotelApp.Forms
{
    partial class CreateUpdateGuestForm
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
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label genderIdLabel;
            System.Windows.Forms.Label statusIdLabel;
            this.hotelDataSet = new HotelApp.hotelDataSet();
            this.guestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestTableAdapter = new HotelApp.hotelDataSetTableAdapters.GuestTableAdapter();
            this.tableAdapterManager = new HotelApp.hotelDataSetTableAdapters.TableAdapterManager();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderIdComboBox = new System.Windows.Forms.ComboBox();
            this.statusIdComboBox = new System.Windows.Forms.ComboBox();
            this.buttonSaveAdditionalFontAttentionBack = new System.Windows.Forms.Button();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderTableAdapter = new HotelApp.hotelDataSetTableAdapters.GenderTableAdapter();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new HotelApp.hotelDataSetTableAdapters.StatusTableAdapter();
            fullNameLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            genderIdLabel = new System.Windows.Forms.Label();
            statusIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
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
            this.buttonBackAdditionalFontAttentionBack.Location = new System.Drawing.Point(109, 67);
            this.buttonBackAdditionalFontAttentionBack.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.buttonSaveAdditionalFontAttentionBack);
            this.splitContainer1.Panel2.Controls.Add(fullNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.fullNameTextBox);
            this.splitContainer1.Panel2.Controls.Add(birthdayLabel);
            this.splitContainer1.Panel2.Controls.Add(this.birthdayDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(genderIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.genderIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(statusIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.statusIdComboBox);
            this.splitContainer1.Size = new System.Drawing.Size(370, 293);
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(80, 25);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(37, 13);
            fullNameLabel.TabIndex = 0;
            fullNameLabel.Text = "ФИО:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(28, 51);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(89, 13);
            birthdayLabel.TabIndex = 2;
            birthdayLabel.Text = "Дата рождения:";
            // 
            // genderIdLabel
            // 
            genderIdLabel.AutoSize = true;
            genderIdLabel.Location = new System.Drawing.Point(87, 77);
            genderIdLabel.Name = "genderIdLabel";
            genderIdLabel.Size = new System.Drawing.Size(30, 13);
            genderIdLabel.TabIndex = 4;
            genderIdLabel.Text = "Пол:";
            // 
            // statusIdLabel
            // 
            statusIdLabel.AutoSize = true;
            statusIdLabel.Location = new System.Drawing.Point(73, 104);
            statusIdLabel.Name = "statusIdLabel";
            statusIdLabel.Size = new System.Drawing.Size(44, 13);
            statusIdLabel.TabIndex = 6;
            statusIdLabel.Text = "Статус:";
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "hotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guestBindingSource
            // 
            this.guestBindingSource.DataMember = "Guest";
            this.guestBindingSource.DataSource = this.hotelDataSet;
            // 
            // guestTableAdapter
            // 
            this.guestTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.GuestTableAdapter = this.guestTableAdapter;
            this.tableAdapterManager.HistoryTableAdapter = null;
            this.tableAdapterManager.HotelTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.RoomTypeTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelApp.hotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(123, 22);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.fullNameTextBox.TabIndex = 1;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.guestBindingSource, "Birthday", true));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(123, 48);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthdayDateTimePicker.TabIndex = 3;
            // 
            // genderIdComboBox
            // 
            this.genderIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "GenderId", true));
            this.genderIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.guestBindingSource, "GenderId", true));
            this.genderIdComboBox.DataSource = this.genderBindingSource;
            this.genderIdComboBox.DisplayMember = "GenderName";
            this.genderIdComboBox.FormattingEnabled = true;
            this.genderIdComboBox.Location = new System.Drawing.Point(123, 74);
            this.genderIdComboBox.Name = "genderIdComboBox";
            this.genderIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.genderIdComboBox.TabIndex = 5;
            this.genderIdComboBox.ValueMember = "IdGender";
            // 
            // statusIdComboBox
            // 
            this.statusIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "StatusId", true));
            this.statusIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.guestBindingSource, "StatusId", true));
            this.statusIdComboBox.DataSource = this.statusBindingSource;
            this.statusIdComboBox.DisplayMember = "StatusName";
            this.statusIdComboBox.FormattingEnabled = true;
            this.statusIdComboBox.Location = new System.Drawing.Point(123, 101);
            this.statusIdComboBox.Name = "statusIdComboBox";
            this.statusIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.statusIdComboBox.TabIndex = 7;
            this.statusIdComboBox.ValueMember = "IdStatus";
            // 
            // buttonSaveAdditionalFontAttentionBack
            // 
            this.buttonSaveAdditionalFontAttentionBack.Location = new System.Drawing.Point(100, 141);
            this.buttonSaveAdditionalFontAttentionBack.Name = "buttonSaveAdditionalFontAttentionBack";
            this.buttonSaveAdditionalFontAttentionBack.Size = new System.Drawing.Size(149, 23);
            this.buttonSaveAdditionalFontAttentionBack.TabIndex = 8;
            this.buttonSaveAdditionalFontAttentionBack.Text = "Сохранить";
            this.buttonSaveAdditionalFontAttentionBack.UseVisualStyleBackColor = true;
            this.buttonSaveAdditionalFontAttentionBack.Click += new System.EventHandler(this.buttonSaveAdditionalFontAttentionBack_Click);
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.hotelDataSet;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.hotelDataSet;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // CreateUpdateGuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 293);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateUpdateGuestForm";
            this.Text = "CreateUpdateGuestForm";
            this.Load += new System.EventHandler(this.CreateUpdateGuestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private hotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource guestBindingSource;
        private hotelDataSetTableAdapters.GuestTableAdapter guestTableAdapter;
        private hotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.ComboBox genderIdComboBox;
        private System.Windows.Forms.ComboBox statusIdComboBox;
        private System.Windows.Forms.Button buttonSaveAdditionalFontAttentionBack;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private hotelDataSetTableAdapters.GenderTableAdapter genderTableAdapter;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private hotelDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
    }
}