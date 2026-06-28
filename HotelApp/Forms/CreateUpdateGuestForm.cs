using HotelApp.Exceptions;
using HotelApp.Models;
using System;
using System.Windows.Forms;

namespace HotelApp.Forms
{
    public partial class CreateUpdateGuestForm : ParentForm
    {
        private Guest guest;

        /// <summary>
        /// Конструктор добавления гостя
        /// </summary>
        public CreateUpdateGuestForm()
        {
            InitializeComponent();
            guest = new Guest();
        }

        /// <summary>
        /// Конструктор редактирования гостя
        /// </summary>
        public CreateUpdateGuestForm(Guest guest)
        {
            InitializeComponent();
            this.guest = guest;
        }

        private void FillModel()
        {
            guest.FullName = fullNameTextBox.Text.Trim();
            guest.Birthday = birthdayDateTimePicker.Value;
            guest.GenderId = (int)genderIdComboBox.SelectedValue;
            guest.StatusId = (int)statusIdComboBox.SelectedValue;
        }

        private void FillData()
        {
            fullNameTextBox.Text = guest.FullName;
            birthdayDateTimePicker.Value = guest.Birthday;
            genderIdComboBox.SelectedValue = guest.GenderId;
            statusIdComboBox.SelectedValue = guest.StatusId;
        }

        private void CreateUpdateGuestForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Status". При необходимости она может быть перемещена или удалена.
            this.statusTableAdapter.Fill(this.hotelDataSet.Status);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.hotelDataSet.Gender);
            
            if (guest.IsNew())
            {
                SetTitle("Добавление гостя");
            }
            else
            {
                SetTitle("Редактирование гостя");
                FillData();
            }
        }

        private void ValidateData()
        {
            if (birthdayDateTimePicker.Value > DateTime.Now)
            {
                throw new ValidationException("Дата рождения должны быть в прошлом!");
            }
        }

        private void buttonSaveAdditionalFontAttentionBack_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateData();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (MessageBox.Show("Сохранить?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                FillModel();
                try
                {
                    if (guest.IsNew())
                    {
                        Program.Context.Guests.Add(guest);
                    }

                    Program.Context.SaveChanges();
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Сохранение успешно!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
