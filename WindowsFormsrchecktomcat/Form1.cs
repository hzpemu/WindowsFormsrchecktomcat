using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace WindowsFormsrchecktomcat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //System.Diagnostics.Process.Start("bhtsoft.bat");
           // this.button1.PerformClick();
            check();
            this.timer21.Start();
        }
        private void timer21_Tick(object sender, EventArgs e)
        {
            this.timer21.Stop();
            check();
            this.timer22.Start();
        }

        private void timer22_Tick(object sender, EventArgs e)
        {
            this.timer22.Stop();
            check();
            this.timer21.Start();
        }

         public bool ProcessName(string ProceName)
        {   Process[] process = Process.GetProcesses();
        bool a = false;
            foreach (Process pres in process)
            {
                if (pres.ProcessName == ProceName )
                {
                    ////获取指定进程内存使用情况
                    //pres.WorkingSet;
                    ////获取指定进程分配的物理内存量
                    //pres.WorkingSet64;
                    ////获取指定进程用户处理器时间
                    //pres.UserProcessorTime;
                    ////获取指定进程用户处理器总时间
                    //pres.TotalProcessorTime;

                    this.label1.Text = pres.WorkingSet64.ToString();
                    this.textBox5.Text = pres.WorkingSet64.ToString();
                    if (pres.WorkingSet64 > long.Parse(this.textBox2.Text))
                    {
                        a = true;
                    }
                    this.label2.Text=a.ToString();
                }  
            }
            return (a);
            //调用的时候
            //ProcessName(进程名);
         }

         public bool ProcessNameMin(string ProceName)
         {
             
             Process[] process = Process.GetProcesses();
             bool a = false;
             foreach (Process pres in process)
             {
                 if (pres.ProcessName == ProceName)
                 {
                     ////获取指定进程内存使用情况
                     //pres.WorkingSet;
                     ////获取指定进程分配的物理内存量
                     //pres.WorkingSet64;
                     ////获取指定进程用户处理器时间
                     //pres.UserProcessorTime;
                     ////获取指定进程用户处理器总时间
                     //pres.TotalProcessorTime;
                     this.label1.Text = pres.WorkingSet64.ToString();
                     this.textBox5.Text = pres.WorkingSet64.ToString();
                     if (pres.WorkingSet64 < long.Parse(this.textBox4.Text))
                     {
                         a = true;
                     }
                     this.label2.Text = a.ToString();
                 }
             }
             return (a);
             //调用的时候
             //ProcessName(进程名);
         }


         private void button1_Click(object sender, EventArgs e)
         {

             check();

         }

         private void check()
         {
             if (this.ProcessName(this.textBox1.Text) == true)
             {
                 System.Diagnostics.Process.Start(System.IO.Directory.GetCurrentDirectory() + "\\" + this.textBox3.Text);

                 savelog();

                 this.label3.Text = System.IO.Directory.GetCurrentDirectory() + "\\" + this.textBox3.Text;

             }
             this.label3.Text = System.IO.Directory.GetCurrentDirectory() + "\\" + this.textBox3.Text;

             this.timer1.Start();
         }

         private void timer1_Tick(object sender, EventArgs e)
         {
             this.label3.Text = "aaa" + this.label3.Text;

             if (this.ProcessNameMin(this.textBox1.Text)== true)
             {
                 System.Diagnostics.Process.Start(System.IO.Directory.GetCurrentDirectory() + "\\" + this.textBox3.Text);

                 savelog();


             }
             //this.Close();
             this.timer1.Stop();
             
         }

         private void savelog()
         {
             try
             {
                 DataClasses1DataContext db1 = new DataClasses1DataContext();
                 var log = new userlog();
                 log.hostname = Dns.GetHostName();

                 IPHostEntry MyEntry = Dns.GetHostByName(Dns.GetHostName());
                 IPAddress MyAddress = new IPAddress(MyEntry.AddressList[0].Address);
                 log.IP = MyAddress.ToString();
                 log.name = "sys";
                 log.userlog1 = "restarttomcat";
                 log.realname = "sys";
                 db1.userlog.InsertOnSubmit(log);
                 db1.SubmitChanges();
             }
             catch { }
         }

         private void Form1_SizeChanged(object sender, EventArgs e)
         {
             if (this.WindowState == FormWindowState.Normal)
             {
                 notifyIcon1.Visible = true; //托盘图标隐藏
             }
             if (this.WindowState == FormWindowState.Minimized)//最小化事件
             {
                 this.Hide();//最小化时窗体隐藏
             }
         }

         private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
         {
             if (this.WindowState == FormWindowState.Minimized)
             {
                 this.Show();
                 this.WindowState = FormWindowState.Normal; //还原窗体
             }
         }

         private void Form1_FormClosing(object sender, FormClosingEventArgs e)
         {
             //DialogResult result;
             //result = MessageBox.Show("确定退出吗？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
             //if (result == DialogResult.OK)
             //{

             //    Application.ExitThread();
             //}
             //else
             //{
             //    e.Cancel = true;
             //}
         }

       
        
    }
}
