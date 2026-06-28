using HotelApp.Constants;
using HotelApp.Services;
using System;
using System.Windows.Forms;

namespace HotelApp.Forms
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Устанавливает заголовок формы
        /// </summary>
        public void SetTitle(string title)
        {
            Text = title;
            labelTitleAttentionFont.Text = title.Trim().ToUpper();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            StyleService.CustomizeControls(splitContainer1.Panel1.Controls);
            StyleService.CustomizeControls(splitContainer1.Panel2.Controls);
            
            BackColor = ColorScheme.MainColor;
        }

        private void buttonBackAdditionalFontAttentionBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
