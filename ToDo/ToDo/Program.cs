using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public static class Program
    {
        public static void Run()
        {
            //MainWindow mainWindow = new MainWindow();
            //mainWindow.Show();
            DetailEntryWindow detailEntryWindow = new DetailEntryWindow();
            detailEntryWindow.Show();
        }
    }
}
