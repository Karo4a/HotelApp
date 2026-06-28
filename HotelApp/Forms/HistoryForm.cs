using HotelApp.Models;
using System.Linq;

namespace HotelApp.Forms
{
    public partial class HistoryForm : ParentForm
    {
        private Guest guest;

        public HistoryForm(Guest guest)
        {
            InitializeComponent();
            this.guest = guest;
        }

        private void HistoryForm_Load(object sender, System.EventArgs e)
        {
            historyBindingSource.DataSource = guest.Histories;

            CommentColumn.Visible = guest.Histories.Select(x => x.Comment).Any(x => x != null);

            SetTitle($"История остановок: {guest.FullName}");
        }
    }
}
