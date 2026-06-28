using HotelApp.Constants;
using HotelApp.Forms;
using HotelApp.Models;
using HotelApp.Services;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HotelApp.CustomControls
{
    public partial class GuestControl : UserControl
    {
        private Guest guest;

        public GuestControl(Guest guest)
        {
            InitializeComponent();
            this.guest = guest;
        }

        private void FillLabels()
        {
            labelName.Text = $"ФИО: {guest.FullName}";
            labelGender.Text = $"Пол: {guest.Gender.GenderName}";
            labelBirthday.Text = $"Дата рождения: {guest.Birthday.ToShortDateString()}";
            labelBookingCount.Text = $"Сколько раз останавливался: {guest.Histories.Count}";
            labelStatus.Text = $"Статус: {guest.Status.StatusName}";
        }

        private void GuestControl_Load(object sender, EventArgs e)
        {
            BackColor = ColorScheme.AdditionalColor;
            StyleService.CustomizeControls(Controls);
            FillLabels();
        }

        private void GuestControl_Paint(object sender, PaintEventArgs e)
        {
            var rect = ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;
            e.Graphics.DrawRectangle(new Pen(ColorScheme.AttentionColor), rect);
        }

        private void buttonHistoryAdditionalFontAttentionBack_Click(object sender, EventArgs e)
        {
            var historyForm = new HistoryForm(guest);
            historyForm.ShowDialog();
        }

        private void onClickEvent(object sender, MouseEventArgs e)
        {
            var updateForm = new CreateUpdateGuestForm(guest);
            var isSaved = updateForm.ShowDialog() == DialogResult.OK;

            if (isSaved)
            {
                var form = (MainForm)ParentForm;
                form.UpdateItems();
            }
        }
    }
}
