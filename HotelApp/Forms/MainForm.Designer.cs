namespace HotelApp.Forms
{
    partial class MainForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddGuestAttentionBackAdditionalFont = new System.Windows.Forms.Button();
            this.labelEditHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitleAttentionFont
            // 
            this.labelTitleAttentionFont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(100)))), ((int)(((byte)(254)))));
            // 
            // buttonBackAdditionalFontAttentionBack
            // 
            this.buttonBackAdditionalFontAttentionBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackAdditionalFontAttentionBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(100)))), ((int)(((byte)(254)))));
            this.buttonBackAdditionalFontAttentionBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(254)))), ((int)(((byte)(57)))));
            this.buttonBackAdditionalFontAttentionBack.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelEditHint);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddGuestAttentionBackAdditionalFont);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 346);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonAddGuestAttentionBackAdditionalFont
            // 
            this.buttonAddGuestAttentionBackAdditionalFont.AutoSize = true;
            this.buttonAddGuestAttentionBackAdditionalFont.Location = new System.Drawing.Point(109, 67);
            this.buttonAddGuestAttentionBackAdditionalFont.Name = "buttonAddGuestAttentionBackAdditionalFont";
            this.buttonAddGuestAttentionBackAdditionalFont.Size = new System.Drawing.Size(98, 23);
            this.buttonAddGuestAttentionBackAdditionalFont.TabIndex = 3;
            this.buttonAddGuestAttentionBackAdditionalFont.Text = "Добавить гостя";
            this.buttonAddGuestAttentionBackAdditionalFont.UseVisualStyleBackColor = true;
            this.buttonAddGuestAttentionBackAdditionalFont.Click += new System.EventHandler(this.buttonAddGuestAttentionBackAdditionalFont_Click);
            // 
            // labelEditHint
            // 
            this.labelEditHint.AutoSize = true;
            this.labelEditHint.Location = new System.Drawing.Point(213, 72);
            this.labelEditHint.Name = "labelEditHint";
            this.labelEditHint.Size = new System.Drawing.Size(256, 13);
            this.labelEditHint.TabIndex = 4;
            this.labelEditHint.Text = "Нажмите по карточке гостя для редактирования";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonAddGuestAttentionBackAdditionalFont;
        private System.Windows.Forms.Label labelEditHint;
    }
}