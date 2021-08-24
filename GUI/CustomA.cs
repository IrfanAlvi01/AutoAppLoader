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
    public partial class CustomA : Form
    {
        public CustomA()
        {
            InitializeComponent();
        }

        private void CustomA_Load(object sender, EventArgs e)
        {
           
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String A = @"C:\AutoLoader\A.txt";

            FileHandleW(A);
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

        private void button1_Click(object sender, EventArgs e)
        {
            String A = @"C:\AutoLoader\A.txt";

            FileHandleR(A);
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

        private void buttonBs_Click(object sender, EventArgs e)
        {
            String B = @"C:\AutoLoader\B.txt";

            FileHandleW(B);
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            String B = @"C:\AutoLoader\B.txt";

            FileHandleR(B);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String C = @"C:\AutoLoader\C.txt";

            FileHandleR(C);
        }

        private void buttonCs_Click(object sender, EventArgs e)
        {
            String C = @"C:\AutoLoader\C.txt";

            FileHandleW(C);
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            String D = @"C:\AutoLoader\D.txt";

            FileHandleR(D);
        }

        private void buttonDs_Click(object sender, EventArgs e)
        {
            String D = @"C:\AutoLoader\D.txt";

            FileHandleW(D);
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            String E = @"C:\AutoLoader\E.txt";

            FileHandleR(E);
        }

        private void buttonEs_Click(object sender, EventArgs e)
        {
            String E = @"C:\AutoLoader\E.txt";

            FileHandleW(E);
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            String F = @"C:\AutoLoader\F.txt";

            FileHandleR(F);
        }

        private void buttonFs_Click(object sender, EventArgs e)
        {
            String F = @"C:\AutoLoader\F.txt";

            FileHandleW(F);
        }
    }
}
