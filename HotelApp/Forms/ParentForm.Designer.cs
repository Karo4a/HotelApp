namespace HotelApp.Forms
{
    partial class ParentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer parentComponents = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (parentComponents != null))
            {
                parentComponents.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonBackAdditionalFontAttentionBack = new System.Windows.Forms.Button();
            this.labelTitleAttentionFont = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonBackAdditionalFontAttentionBack);
            this.splitContainer1.Panel1.Controls.Add(this.labelTitleAttentionFont);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonBackAdditionalFontAttentionBack
            // 
            this.buttonBackAdditionalFontAttentionBack.Location = new System.Drawing.Point(713, 10);
            this.buttonBackAdditionalFontAttentionBack.Name = "buttonBackAdditionalFontAttentionBack";
            this.buttonBackAdditionalFontAttentionBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBackAdditionalFontAttentionBack.TabIndex = 2;
            this.buttonBackAdditionalFontAttentionBack.Text = "Назад";
            this.buttonBackAdditionalFontAttentionBack.UseVisualStyleBackColor = true;
            this.buttonBackAdditionalFontAttentionBack.Click += new System.EventHandler(this.buttonBackAdditionalFontAttentionBack_Click);
            // 
            // labelTitleAttentionFont
            // 
            this.labelTitleAttentionFont.AutoSize = true;
            this.labelTitleAttentionFont.Location = new System.Drawing.Point(106, 15);
            this.labelTitleAttentionFont.Name = "labelTitleAttentionFont";
            this.labelTitleAttentionFont.Size = new System.Drawing.Size(116, 13);
            this.labelTitleAttentionFont.TabIndex = 1;
            this.labelTitleAttentionFont.Text = "Родительская форма";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelApp.Properties.Resources.bee;
            this.pictureBox1.Location = new System.Drawing.Point(20, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParentForm";
            this.Text = "ParentForm";
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Label labelTitleAttentionFont;
        protected System.Windows.Forms.Button buttonBackAdditionalFontAttentionBack;
        protected System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.SplitContainer splitContainer1;
    }
}