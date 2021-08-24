using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Diagnostics;

namespace GUI
{
    public partial class panelShooter : Form
    {
        public panelShooter()
        {
            InitializeComponent();
        }

        private void panelShooter_Load(object sender, EventArgs e)
        {
           
        }

        public String Time()
        {
            DateTime now = DateTime.Now;
            String Date1 = now.Hour + " " + now.Minute + " " + now.Second + " " + now.Millisecond + " ," + now.Day;
            Console.WriteLine(Date1);
            Update();

            return Date1;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        string value = " ";
        

        Image myImage;
        //public String path = "D:";
        public String Saver;

        private void buttonCapture_Click(object sender, EventArgs e)
        {
            capture();
            String T = Time();

            string line = " ";
            using (StreamReader sr = new StreamReader(@"C:\AutoLoader\Save.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    //Console.WriteLine("inloop" + line);
                    value = line;
                }
            }
            Console.WriteLine("reader:"+ value);
        
            String path;
            if (value == " ")
            {
                path = "D:";
                path = path + @"\" + T + ".JPG";
            }
            else
            {
                Console.WriteLine("IN LINE");
                path = value + @"\" + T + ".JPG";
                Console.WriteLine("LINE:"+path);
            }

            Console.WriteLine(path);



            /*
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPG(*.JPG)|*.JPG";

            if (sf.ShowDialog() == DialogResult.OK)
            {
            myImage.Save(sf.FileName);
            }  
            */
            
            myImage.Save(path);
            //path = "D:";
            //this.Show();         
        }



        void capture()
        {
            //this.Hide();
            foreach (Form f in Application.OpenForms)
            {

                f.WindowState = FormWindowState.Minimized;

            }

            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("{PRTSC}");
            myImage = Clipboard.GetImage();
            pictureBox1.Image = myImage;

            foreach (Form f in Application.OpenForms)
            {

                f.WindowState = FormWindowState.Maximized;

            }

        }


        //ClipBoard-ScreenShooter//
        
        private void buttonCapture2_Click(object sender, EventArgs e)
        {
                String path1 = "D:";
                System.Threading.Thread.Sleep(1000);
                myImage = Clipboard.GetImage();
                pictureBox1.Image = myImage;

                String TT = Time();

            string line = " ";
            using (StreamReader sr = new StreamReader(@"C:\AutoLoader\Save.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    //Console.WriteLine("inloop" + line);
                    value = line;
                }
            }
            Console.WriteLine("reader:" + value);

            //String path;
            if (value == " ")
            {
                path1 = "D:";
                path1 = path1 + @"\" + TT + ".JPG";
            }
            else
            {
                Console.WriteLine("IN Clip");
                path1 = value + @"\" + TT + ".JPG";
                Console.WriteLine("LINE:" + path1);
            }



            //path1 = path1 + @"\" + TT + ".JPG";
                
                Console.WriteLine(path1);
                myImage.Save(path1);
            
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            String selectedFolder;
            using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
            {

                System.Windows.Forms.DialogResult result = dialog.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    selectedFolder = dialog.SelectedPath;
                    Console.WriteLine("Path:" + dialog.SelectedPath);
                    //SSsaver(dialog.SelectedPath);


                    string path = @"C:\AutoLoader\Save.txt";
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


                    string[] names = new string[] { dialog.SelectedPath };

                    using (StreamWriter sw = new StreamWriter(path))
                    {

                        foreach (string s in names)
                        {
                            sw.WriteLine(s);
                        }
                    }

                }
            }
        }


        /*
        void SSsaver(String add)
        {
            string p = add +@"\save.txt";
            if (File.Exists(p))
            {
                File.Delete(p);
                Console.WriteLine("File A Deleted");
            }
            if (!File.Exists(p))
            {
                Console.WriteLine("File A Not Exist");
            }
            File.Create(p).Dispose();




            string[] names = new string[] { link };

            using (StreamWriter sw = new StreamWriter(address))
            {

                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }

        }   */


    }
}
