using HotelApp.Constants;
using System.Windows.Forms;

namespace HotelApp.Services
{
    /// <summary>
    /// Сервис для работы со стилем приложения
    /// </summary>
    public class StyleService
    {
        /// <summary>
        /// Применить цветовую схему приложения к элементам управления
        /// </summary>
        public static void CustomizeControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control.Name.Contains("AttentionFont"))
                {
                    control.ForeColor = ColorScheme.AttentionColor;
                }
                else if (control.Name.Contains("AdditionalFont"))
                {
                    control.ForeColor = ColorScheme.AdditionalColor;
                }

                if (control.Name.Contains("AttentionBack"))
                {
                    control.BackColor = ColorScheme.AttentionColor;
                }
                else if (control.Name.Contains("AdditionalBack"))
                {
                    control.BackColor= ColorScheme.AdditionalColor;
                }
            }
        }
    }
}
