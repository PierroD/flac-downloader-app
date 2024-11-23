using FlacDownloader.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlacDownloader.Classes
{
    public static class Navigation
    {
        public static List<GoToObject> navigationHistory { get; set; }
        private static int navigationIndex = -1;
        public static void Push(GoToEnum goToEnum)
        {
            if (navigationHistory != null && navigationIndex != -1 && navigationHistory[navigationIndex].goTo == goToEnum)
            {
                return;
            }
            Push(new GoToObject(null, goToEnum, FromEnum.NONE));
        }

        public static void Push(GoToObject obj)
        {
            if (navigationHistory == null)
            {
                navigationHistory = new List<GoToObject>();
            }
            if (navigationIndex != -1 && navigationIndex <= navigationHistory.Count() - 1)
            {
                if (navigationHistory != null && navigationIndex != 0 && navigationHistory.Count > 0 && navigationHistory[navigationIndex].goTo == obj.goTo)
                {
                    return;
                }
                if (navigationIndex != navigationHistory.Count() - 1)
                {
                    int startIndex = navigationIndex + 1;
                    int endIndex = navigationHistory.Count() - 1;
                    int count = endIndex - startIndex + 1;
                    navigationHistory.RemoveRange(startIndex, count);
                }
            }
            navigationHistory.Add(obj);
            navigationIndex += 1;
        }

        public static bool CanGoLeft()
        {
            return navigationIndex > 0;
        }

        public static bool CanGoRight()
        {
            return navigationIndex + 1 < navigationHistory.Count();
        }


        public static GoToObject GoLeft()
        {
            navigationIndex -= 1;
            return navigationHistory[navigationIndex];
        }
        public static GoToObject GoRight()
        {
            navigationIndex += 1;
            return navigationHistory[navigationIndex];
        }

        public static GoToObject CurrentNavigation()
        {
            if (navigationHistory == null || navigationIndex == -1)
            {
                return new GoToObject(null, Enums.GoToEnum.HOME, Enums.FromEnum.NONE);
            }
            return navigationHistory[navigationIndex];
        }
    }
}
