using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlacDownloader.Utils
{
    static class AppColors
    {
        public static Color textColor
        {
            get { return AppSettings.isDarkMode ? DarkMode.text : LightMode.text; }
        }
        public static Color backgroundColor
        {
            get { return AppSettings.isDarkMode ? DarkMode.background : LightMode.background; }
        }
        public static Color backgroundSecondaryColor
        {
            get { return AppSettings.isDarkMode ? DarkMode.backgroundSecondary : LightMode.backgroundSecondary; }
        }
        public static Color primaryColor
        {
            get { return AppSettings.isDarkMode ? DarkMode.primary : LightMode.primary; }
        }
        public static Color secondaryColor
        {
            get { return AppSettings.isDarkMode ? DarkMode.secondary : LightMode.secondary; }
        }
        public static Color accentColor
        {
            get { return AppSettings.isDarkMode ? DarkMode.accent : LightMode.accent; }
        }

        public static Color AdaptativeTextColor(bool  isDark)
        {
            return isDark ? LightMode.text : DarkMode.text;
        }

        static class LightMode
        {
            public static Color text { get; } = Color.FromArgb(16,16,16);
            public static Color background { get; } = Color.FromArgb(237, 237, 237);
            public static Color backgroundSecondary { get; } = Color.FromArgb(226,226,226);
            public static Color primary { get; } = Color.FromArgb(255, 138, 61);
            public static Color secondary { get; } = Color.FromArgb(201, 135, 135);
            public static Color accent { get; } = Color.FromArgb(181, 64, 64);

        }

        static class DarkMode
        {
            public static Color text { get; } = Color.FromArgb(238, 235, 235);
            public static Color background { get; } = Color.FromArgb(0, 0, 0);
            public static Color backgroundSecondary { get; } = Color.FromArgb(18, 18, 18);
            public static Color primary { get; } = Color.FromArgb(255, 138, 61);
            public static Color secondary { get; } = Color.FromArgb(120, 54, 54);
            public static Color accent { get; } = Color.FromArgb(191, 74, 74);

        }

    }
}
