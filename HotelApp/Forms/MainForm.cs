using HotelApp.CustomControls;
using HotelApp.Services;
using System.Linq;
using System.Windows.Forms;

namespace HotelApp.Forms
{
    public partial class MainForm : ParentForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузить список гостей
        /// </summary>
        public void LoadItems()
        {
            var guests = Program.Context.Guests;
            var controls = new GuestControl[guests.Count()];
            int index = 0;
            foreach (var guest in guests)
            {
                controls[index] = new GuestControl(guest);
                ++index;
            }
            flowLayoutPanel1.Controls.AddRange(controls);
            StyleService.CustomizeControls(flowLayoutPanel1.Controls);
        }

        /// <summary>
        /// Очистить список гостей
        /// </summary>
        public void ClearItems()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        /// <summary>
        /// Обновить список гостей
        /// </summary>
        public void UpdateItems()
        {
            ClearItems();
            LoadItems();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            SetTitle("Список гостей");
            LoadItems();
        }

        private void buttonAddGuestAttentionBackAdditionalFont_Click(object sender, System.EventArgs e)
        {
            var createForm = new CreateUpdateGuestForm();
            var isSaved = createForm.ShowDialog() == DialogResult.OK;
            
            if (isSaved)
            {
                UpdateItems();
            }
        }
    }
}
