using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AutoLoader : Form
    {
        private int i = 0;
        public AutoLoader()
        {
            int i = 1;
            DirCreate(i);
            
            InitializeComponent();
            hideSubMenu();
         
        }
        int y = 1;
        public void DirCreate(int x)
        {
            
            
            Console.WriteLine(y);
            if (y<3)
            {
                const string path = "C:\\AutoLoader";
                const string pathS = "D:\\ScreenShots";
                while (y<3)
                {
                    y = y + x;
                    if (Directory.Exists(path))
                        //throw new Exception("Confirmed");
                        Console.WriteLine("FileExist");
                    //Directory.Delete(path);
                    Directory.CreateDirectory(path);
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                        //throw new Exception("Confirmed");
                    }


                    if (Directory.Exists(pathS))
                        Console.WriteLine("FileExist");
                    else
                    Directory.CreateDirectory(pathS);


                    //SS-Save//
                    string pathSF = @"C:\AutoLoader\Save.txt";
                    
                    if (!File.Exists(pathSF))
                    {
                        Console.WriteLine("SaveFile Not existed, In main");
                        File.Create(pathSF).Dispose();
                    }
                    


                }
            }



        }

        private void hideSubMenu()
        {
            panelMain.Visible = false;
            panelApplications.Visible = false;
            panelShooter.Visible = false;
            panelSettings.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }





        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }


        #region MainMenu

        private void MainMenu_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelMain);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //code here//
            openChildForm(new SubMainForm1());

            hideSubMenu();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //code here//
            openChildForm(new SubMainForm2());

            hideSubMenu();
        }

        #endregion


        #region ApplicationMenu
        private void Applications_Click(object sender, EventArgs e)
        {
            showSubMenu(panelApplications);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //code here//
            openChildForm(new CustomA());

            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //code here//
            openChildForm(new CustomB());

            hideSubMenu();
        }

        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo(@"C:\Windows\System32\control.exe");
            info.UseShellExecute = false;
            info.RedirectStandardError = true;
            info.RedirectStandardInput = true;
            info.RedirectStandardOutput = true;
            info.CreateNoWindow = true;
            info.ErrorDialog = false;
            info.WindowStyle = ProcessWindowStyle.Hidden;

            Process process = Process.Start(info);

        }

   

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelStart_Paint(object sender, PaintEventArgs e)
        {

        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelStart.Controls.Add(childForm);
            panelStart.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TaskMgrbutton_Click(object sender, EventArgs e)
        {
            Process.Start("c:\\windows\\system32\\Taskmgr.exe");
        }

        private void Controlbutton_Click(object sender, EventArgs e)
        {
            
                ProcessStartInfo info = new ProcessStartInfo(@"C:\windows\system32\control.exe");
                info.UseShellExecute = false;
                info.RedirectStandardError = true;
                info.RedirectStandardInput = true;
                info.RedirectStandardOutput = true;
                info.CreateNoWindow = true;
                info.ErrorDialog = false;
                info.WindowStyle = ProcessWindowStyle.Hidden;

                Process process = Process.Start(info);

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            openChildForm(new SettingsForm());
        }

        private void Shooter_Click(object sender, EventArgs e)
        {
            openChildForm(new panelShooter());
        }

        void AppStart()
        {
            string[] links= {"a", "a", "a", "a", "a", "a", "a", "a", "a", "a" };
            links[0] = @"C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE\devenv.exe";
            links[1] = @"C:\Program Files\Image-Line\FL Studio 20\FL64.exe";
            links[2] = @"C:\Qt\Tools\QtCreator\bin\qtcreator.exe";
            links[3] = @"C:\Program Files\Android\Android Studio\bin\studio64.exe";
            links[4] = @"C:\Program Files\CCleaner\CCleaner64.exe";
            links[5] = @"C:\Program Files\7-Zip\7zFM.exe";
            links[6] = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
            links[7] = @"C:\Program Files (x86)\KeePass Password Safe 2\KeePass.exe";
            links[8] = @"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE";
            links[9] = @"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE";

        }


        #region Capture#
        string value = " ";
        Image myImage;
        private void buttonStart_Click(object sender, EventArgs e)
        {
            //Start Button//

            for (int i = 0; i < 10; i++)
            {
                loadfun(i);
                Thread.Sleep(1000);
                fun();
                
            }
            foreach (Form f in Application.OpenForms)
            {

                f.WindowState = FormWindowState.Maximized;

            }
        }

        void loadfun(int j)
        {
            string[] links = { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a" };
            links[0] = @"C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE\devenv.exe";
            links[1] = @"C:\Program Files\Image-Line\FL Studio 20\FL64.exe";
            links[2] = @"C:\Qt\Tools\QtCreator\bin\qtcreator.exe";
            links[3] = @"C:\Program Files\Android\Android Studio\bin\studio64.exe";
            links[4] = @"C:\Program Files\CCleaner\CCleaner64.exe";
            links[5] = @"C:\Program Files\7-Zip\7zFM.exe";
            links[6] = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
            links[7] = @"C:\Program Files (x86)\KeePass Password Safe 2\KeePass.exe";
            links[8] = @"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE";
            links[9] = @"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE";

            void loadingcode(int k)
            {

                try
                {
                    ProcessStartInfo info = new ProcessStartInfo(links[k]);
                    info.UseShellExecute = false;
                    info.RedirectStandardError = true;
                    info.RedirectStandardInput = true;
                    info.RedirectStandardOutput = true;
                    info.CreateNoWindow = true;
                    info.ErrorDialog = false;
                    info.WindowStyle = ProcessWindowStyle.Hidden;

                    Process process = Process.Start(info);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            loadingcode(j);

        }

        void fun()
        {
            capture();
            String T = Time();

            string line = " ";
            using (StreamReader sr = new StreamReader(@"C:\AutoLoader\Save.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    value = line;
                }
            }
            Console.WriteLine("reader:" + value);

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
                Console.WriteLine("LINE:" + path);
            }

            Console.WriteLine(path);

            myImage.Save(path);
        }

        public String Time()
        {
            DateTime now = DateTime.Now;
            String Date1 = now.Hour + " " + now.Minute + " " + now.Second + " " + now.Millisecond + " ," + now.Day;
            Console.WriteLine(Date1);
            Update();

            return Date1;
        }

        void capture()
        {
            //this.Hide();
            foreach (Form f in Application.OpenForms)
            {

                f.WindowState = FormWindowState.Minimized;

            }

            Thread.Sleep(5000);
            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("{PRTSC}");
            myImage = Clipboard.GetImage();
            //pictureBox1.Image = myImage;

            //foreach (Form f in Application.OpenForms)
            //{

                //f.WindowState = FormWindowState.Maximized;

            //}

        }


        #endregion Capture#

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                Process.Start("calc.exe");
            }
            catch (Exception f)
            {
                Console.WriteLine(f.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("mspaint.exe");
            }
            catch (Exception g)
            {
                Console.WriteLine(g.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo(@"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE");
                info.UseShellExecute = false;
                info.RedirectStandardError = true;
                info.RedirectStandardInput = true;
                info.RedirectStandardOutput = true;
                info.CreateNoWindow = true;
                info.ErrorDialog = false;
                info.WindowStyle = ProcessWindowStyle.Hidden;

                Process process = Process.Start(info);
            }
            catch (Exception h)
            {
                Console.WriteLine(h.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("notepad.exe");
            }
            catch (Exception j)
            {
                Console.WriteLine(j.Message);
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo(@"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE");
                info.UseShellExecute = false;
                info.RedirectStandardError = true;
                info.RedirectStandardInput = true;
                info.RedirectStandardOutput = true;
                info.CreateNoWindow = true;
                info.ErrorDialog = false;
                info.WindowStyle = ProcessWindowStyle.Hidden;

                Process process = Process.Start(info);
            }
            catch (Exception k)
            {
                Console.WriteLine(k.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo(@"C:\Program Files\Microsoft Office\root\Office16\POWERPNT.EXE");
                info.UseShellExecute = false;
                info.RedirectStandardError = true;
                info.RedirectStandardInput = true;
                info.RedirectStandardOutput = true;
                info.CreateNoWindow = true;
                info.ErrorDialog = false;
                info.WindowStyle = ProcessWindowStyle.Hidden;

                Process process = Process.Start(info);
            }
            catch (Exception l)
            {
                Console.WriteLine(l.Message);
            }

            try
            {
                ProcessStartInfo info = new ProcessStartInfo(@"C:\Program Files\Microsoft Office\root\Office16\OUTLOOK.EXE");
                info.UseShellExecute = false;
                info.RedirectStandardError = true;
                info.RedirectStandardInput = true;
                info.RedirectStandardOutput = true;
                info.CreateNoWindow = true;
                info.ErrorDialog = false;
                info.WindowStyle = ProcessWindowStyle.Hidden;

                Process process = Process.Start(info);
            }
            catch (Exception m)
            {
                Console.WriteLine(m.Message);
            }

            try
            {
                ProcessStartInfo info = new ProcessStartInfo(@"C:\Program Files\Microsoft Office\root\Office16\MSACCESS.EXE");
                info.UseShellExecute = false;
                info.RedirectStandardError = true;
                info.RedirectStandardInput = true;
                info.RedirectStandardOutput = true;
                info.CreateNoWindow = true;
                info.ErrorDialog = false;
                info.WindowStyle = ProcessWindowStyle.Hidden;

                Process process = Process.Start(info);
            }
            catch (Exception n)
            {
                Console.WriteLine(n.Message);
            }

            try
            {
                ProcessStartInfo info = new ProcessStartInfo(@"C:\Program Files\Microsoft Office\root\Office16\MSPUB.EXE");
                info.UseShellExecute = false;
                info.RedirectStandardError = true;
                info.RedirectStandardInput = true;
                info.RedirectStandardOutput = true;
                info.CreateNoWindow = true;
                info.ErrorDialog = false;
                info.WindowStyle = ProcessWindowStyle.Hidden;

                Process process = Process.Start(info);
            }
            catch (Exception o)
            {
                Console.WriteLine(o.Message);
            }

        }
    }
}
