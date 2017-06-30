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


namespace Win
{
    public partial class Form1 : Form
    {
        static int DKSINIRI=180;
        int TODAY=0;
        int MONTH = 0;
        int YEAR= 0;
        int HOUR=0;
        int MIN = 0;

        string ACTIVEUSER=null;
        string ACTIVEPW = null;
        string dosya_yolu = null;
        int ToplamSure = 0;



        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            System.Diagnostics.Process.Start("shutdown", "-s -t 300");

            DateTime UTCNow = DateTime.UtcNow;
            TODAY = UTCNow.Day;
            MONTH = UTCNow.Month;
            YEAR = UTCNow.Year;
           
            dosya_yolu = @"E:\EmreZamanLog\" + TODAY.ToString()+"."+ MONTH.ToString()+"."+YEAR.ToString() + ".txt";
            
            
            appHizala.Interval = 3700;//7 Sn
            logUpdate.Interval = 300 * 1000;//5 Dk 
            appHizala.Start();
           
        }
        

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x80;  // Turn on WS_EX_TOOLWINDOW
                return cp;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {            
            ACTIVEUSER = textBox1.Text.ToLower();
            ACTIVEPW = textBox2.Text.ToLower();
            if (ACTIVEUSER.Equals("eren"))
            {
                appHizala.Start();
                logUpdate.Start();
                LogRead(ACTIVEUSER);

                System.Diagnostics.Process.Start("shutdown", "-a");
                System.Diagnostics.Process.Start("shutdown", "-s -t " + ((DKSINIRI - ToplamSure)*60).ToString() + "");

            }
            else if (ACTIVEUSER.Equals("root") && ACTIVEPW.Equals("root"))
                    {
                        System.Diagnostics.Process.Start("shutdown", "-a");
                        appHizala.Stop();
                        logUpdate.Stop();
                        TopMost = false;
                    }

        }

        public void LogWrite()
        {
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            
            DateTime UTCNow = DateTime.UtcNow;

            HOUR = UTCNow.Hour+3;
            MIN = UTCNow.Minute;

            File.AppendAllText(@"" + dosya_yolu + "", "" + TODAY.ToString() + ";" + ACTIVEUSER + ";5;"+HOUR.ToString()+":"+MIN.ToString()+ Environment.NewLine);
            

            LogRead(ACTIVEUSER);
        }

        public void LogRead(string userName)
        {
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();
            ToplamSure = 0;

            while (yazi != null)
            {
                 
                string [] parsed = yazi.Split(';');
                if(parsed[0].Equals(TODAY.ToString()) && parsed[1].Equals(userName))
                {
                    ToplamSure += Convert.ToInt32(parsed[2]);
                }              
                yazi = sw.ReadLine();

            }

            if (ToplamSure > DKSINIRI)
            {               
                label3.Text=("SUREN DOLDU 2.5DK İÇİNDE PC KAPATILACAK");
                TopMost = true;
                appHizala.Start();
                logUpdate.Stop();
                System.Diagnostics.Process.Start("shutdown", "-a");

                System.Diagnostics.Process.Start("shutdown","-s -t 150");
            }
            else
            {
                label3.Text = ("Bugünlük Kalan Süren" + (DKSINIRI - ToplamSure).ToString());
               appHizala.Stop();
               TopMost = false;

            }
            sw.Close();
            fs.Close();
        }

        private void appHizala_Tick(object sender, EventArgs e)
        {
            Shell32.ShellClass objShel = new Shell32.ShellClass();
            objShel.ToggleDesktop();
            this.Location = new Point(0, 0);
        }

        private void logUpdate_Tick(object sender, EventArgs e)
        {
            LogWrite();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("root"))
            { this.Close();}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //pause
            System.Diagnostics.Process.Start("shutdown", "-a");
            TopMost = true;
            appHizala.Start();
            logUpdate.Stop();

           // SendKeys.Send("{LWINDOWN}");
            //System.Diagnostics.Process.Start(@"C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Alt)
            {
                e.SuppressKeyPress = true;
                label1.Text = "ent";
            }
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();
            int cikisTotal = 0;

            while (yazi != null)
            {

                string[] parsed = yazi.Split(';');
                if (parsed[0].Equals(TODAY.ToString()) && parsed[1].Equals("eren"))
                {
                    cikisTotal += Convert.ToInt32(parsed[2]);
                }
                yazi = sw.ReadLine();

            }
            fs.Close();

            FileStream fsYaz = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            fsYaz.Close();
            
            File.AppendAllText(@"" + dosya_yolu + "", "x;x;0;" + cikisTotal.ToString() + Environment.NewLine);

            if (textBox1.Text == "root" && textBox2.Text == "root")
            {
                System.Diagnostics.Process.Start("shutdown", "-a");
            }
            else{
                System.Diagnostics.Process.Start("shutdown", "-a");
                System.Diagnostics.Process.Start("shutdown", "-s -t 30");
            }
        }

     
    }
}
