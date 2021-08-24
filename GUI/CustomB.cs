using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CustomB : Form
    {
        public CustomB()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void FileHandleW(String address)
        {
            int x = 0;
            while (x == 0)
            {
                string path = address;
                if (File.Exists(path))
                {
                    File.Delete(path);
                    Console.WriteLine("File A Deleted");
                }
                if (!File.Exists(path))
                {
                    Console.WriteLine("File A Not Exist");
                }
                File.Create(path).Dispose();

                x++;

                //Opening-DialogBox-T0-COpyLink//
                string strtext;
                openFileDialog1.Filter = "Executionable File | *.exe";
                openFileDialog1.InitialDirectory = @"C:\Program Files";
                openFileDialog1.Title = "Select App Path";
                openFileDialog1.ShowDialog();

                strtext = openFileDialog1.FileName;
                //MsgBox(strtext);
                //ShowDialog(strtext);
                Console.WriteLine(strtext);


                //Writing-Link-In-#-File// 
                string[] names = new string[] { strtext };

                using (StreamWriter sw = new StreamWriter(address))
                {

                    foreach (string s in names)
                    {
                        sw.WriteLine(s);
                    }
                }


            }

        }


        public void FileHandleR(String address)
        {
            int x = 0;
            string line = "";
            //string link;
            try
            {
                using (StreamReader sr = new StreamReader(address))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Console.WriteLine("Hi"+line);
                        if (x < 1)
                        {
                            x++;
                            //Console.WriteLine("Hi" + link);
                            Process.Start(line);
                        }
                    }

                }
            }//end of try//
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }


        private void buttonA_Click(object sender, EventArgs e)
        {
            String G = @"C:\AutoLoader\G.txt";

            FileHandleR(G);
        }

        private void buttonGs_Click(object sender, EventArgs e)
        {
            String G = @"C:\AutoLoader\G.txt";

            FileHandleW(G);
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            String H = @"C:\AutoLoader\H.txt";

            FileHandleR(H);
        }

        private void buttonHs_Click(object sender, EventArgs e)
        {
            String H = @"C:\AutoLoader\H.txt";

            FileHandleW(H);
        }

        private void CustomB_Load(object sender, EventArgs e)
        {

        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            String I = @"C:\AutoLoader\I.txt";

            FileHandleR(I);
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            String K = @"C:\AutoLoader\K.txt";

            FileHandleR(K);
        }

        private void buttonKs_Click(object sender, EventArgs e)
        {
            String K = @"C:\AutoLoader\K.txt";

            FileHandleW(K);
        }

        private void buttonIs_Click(object sender, EventArgs e)
        {
            String I = @"C:\AutoLoader\I.txt";

            FileHandleW(I);
        }

        private void buttonJs_Click(object sender, EventArgs e)
        {
            String J = @"C:\AutoLoader\J.txt";

            FileHandleW(J);
        }

        private void buttonLs_Click(object sender, EventArgs e)
        {
            String L = @"C:\AutoLoader\L.txt";

            FileHandleW(L);
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            String L = @"C:\AutoLoader\L.txt";

            FileHandleR(L);
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            String J = @"C:\AutoLoader\J.txt";

            FileHandleR(J);
        }
    }
}
