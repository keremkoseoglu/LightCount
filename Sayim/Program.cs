using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sayim
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static Uoms uoms;
        public static Warehouses warehouses;
        public static Form1 form1;
        public static Form2 form2;
        public static Form3 form3;

        public static bool mustAnalyseBarkodForMeins;
        
        private static string _fileName;

        [MTAThread]
        static void Main()
        {
            uoms = new Uoms();
            warehouses = new Warehouses();
            form1 = new Form1();
            fileName = "";
            Application.Run(form1);
        }

        public static string applicationPath
        {
            get
            {
                return System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.Replace(@"file:///", "").Replace(@"file://", "").Replace(@"/sayim.exe", "").Replace(@"/", @"\").Replace(@"\Sayim.exe", "");
            }
        }

        public static string fileName
        {
            get
            {
                if (_fileName.Length <= 0) _fileName = applicationPath + @"\" + DateTime.Now.ToFileTime() + ".xml";
                return _fileName;
            }

            set
            {
                _fileName = value;
            }
        }
    }
}