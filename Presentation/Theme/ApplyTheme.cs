using System.Drawing;

namespace Presentation.Theme
{
    public class ApplyTheme
    {
        //Esta clase aplica el tema obscuro o blanco

        public static void ApplyDarkMode()
        {
            Properties.Settings.Default.background_color = Color.FromArgb(31, 33, 37);
            Properties.Settings.Default.label_color = Color.WhiteSmoke;
            Properties.Settings.Default.label_title_color = Color.WhiteSmoke;
            Properties.Settings.Default.label_help_color = Color.DarkGray;
            Properties.Settings.Default.control_border_color = Color.FromArgb(60, 62, 65);
            Properties.Settings.Default.control_fill_color = Color.FromArgb(50, 52, 55);
            Properties.Settings.Default.control_fore_color = Color.Gainsboro;
            Properties.Settings.Default.control_focused_fore_color = Color.Gainsboro;
            Properties.Settings.Default.control_focused_fill_color = Color.FromArgb(31, 33, 37);
            Properties.Settings.Default.ts_dark_mode = true;
            Properties.Settings.Default.Save();
        }

        public static void ApplyLightMode()
        {
            Properties.Settings.Default.background_color = Color.White;
            Properties.Settings.Default.label_color = Color.FromArgb(85, 85, 85);
            Properties.Settings.Default.label_title_color = Color.FromArgb(64, 64, 64);
            Properties.Settings.Default.label_help_color = Color.DarkGray;
            Properties.Settings.Default.control_border_color = Color.FromArgb(217, 221, 226);
            Properties.Settings.Default.control_fill_color = Color.WhiteSmoke;
            Properties.Settings.Default.control_fore_color = Color.DimGray;
            Properties.Settings.Default.control_focused_fore_color = Color.White;
            Properties.Settings.Default.control_focused_fill_color = Color.White;
            Properties.Settings.Default.ts_dark_mode = false;
            Properties.Settings.Default.Save();
        }
    }
}
