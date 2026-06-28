namespace HotelApp.CustomControls
{
    partial class GuestControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelBookingCount = new System.Windows.Forms.Label();
            this.buttonHistoryAdditionalFontAttentionBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(453, 9);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(44, 13);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Статус:";
            this.labelStatus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onClickEvent);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(15, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "ФИО:";
            this.labelName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onClickEvent);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(15, 33);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(30, 13);
            this.labelGender.TabIndex = 2;
            this.labelGender.Text = "Пол:";
            this.labelGender.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onClickEvent);
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(15, 60);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(89, 13);
            this.labelBirthday.TabIndex = 3;
            this.labelBirthday.Text = "Дата рождения:";
            this.labelBirthday.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onClickEvent);
            // 
            // labelBookingCount
            // 
            this.labelBookingCount.AutoSize = true;
            this.labelBookingCount.Location = new System.Drawing.Point(15, 85);
            this.labelBookingCount.Name = "labelBookingCount";
            this.labelBookingCount.Size = new System.Drawing.Size(160, 13);
            this.labelBookingCount.TabIndex = 4;
            this.labelBookingCount.Text = "Сколько раз останавливался:";
            this.labelBookingCount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onClickEvent);
            // 
            // buttonHistoryAdditionalFontAttentionBack
            // 
            this.buttonHistoryAdditionalFontAttentionBack.Location = new System.Drawing.Point(479, 80);
            this.buttonHistoryAdditionalFontAttentionBack.Name = "buttonHistoryAdditionalFontAttentionBack";
            this.buttonHistoryAdditionalFontAttentionBack.Size = new System.Drawing.Size(75, 23);
            this.buttonHistoryAdditionalFontAttentionBack.TabIndex = 5;
            this.buttonHistoryAdditionalFontAttentionBack.Text = "История";
            this.buttonHistoryAdditionalFontAttentionBack.UseVisualStyleBackColor = true;
            this.buttonHistoryAdditionalFontAttentionBack.Click += new System.EventHandler(this.buttonHistoryAdditionalFontAttentionBack_Click);
            // 
            // GuestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonHistoryAdditionalFontAttentionBack);
            this.Controls.Add(this.labelBookingCount);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelStatus);
            this.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.Name = "GuestControl";
            this.Size = new System.Drawing.Size(566, 110);
            this.Load += new System.EventHandler(this.GuestControl_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GuestControl_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onClickEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelBookingCount;
        private System.Windows.Forms.Button buttonHistoryAdditionalFontAttentionBack;
    }
}
