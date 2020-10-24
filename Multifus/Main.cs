using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Multifus
{
  
    public partial class Main : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        // When you don't want the ProcessId, use this overload and pass IntPtr.Zero for the second parameter
        [DllImport("user32.dll")]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        public Main()
        {
            InitializeComponent();
        }

        private void ValidCharnamesBtn_Click(object sender, EventArgs e)
        {
            Personnage1TextBox.Enabled = false;
            Personnage2TextBox.Enabled = false;
            Personnage3TextBox.Enabled = false;
            Personnage4TextBox.Enabled = false;
            CharSwap.Enabled = true;


            this.Hide();
            CharSwapper SwapperForm = new CharSwapper();
            SwapperForm.ShowDialog();
            this.Close();

        }

        private void CharSwap_Tick(object sender, EventArgs e)
        {
            Parssing.Pers1= Personnage1TextBox.Text;
            Parssing.Pers2 = Personnage2TextBox.Text;
            Parssing.Pers3 = Personnage3TextBox.Text;
            Parssing.Pers4 = Personnage4TextBox.Text;
            bool ACC1 = false;
            bool ACC2 = false;
            bool ACC3 = false;
            bool ACC4 = false;

            if (Keyboard.IsKeyDown(Key.F10))
            {
                if (ACC1 = false)
                {
                    LogBox.AppendText("Account #1");
                    IntPtr hWnd = FindWindow(null, this.Personnage1TextBox.Text.ToString() + " - Dofus 2.57.6.7");
                    SetForegroundWindow(hWnd);
                    ACC1 = true;
                }
                if(ACC2 = false)
                {
                    LogBox.AppendText("Account #2");
                    IntPtr hWnd = FindWindow(null, this.Personnage2TextBox.Text.ToString() + " - Dofus 2.57.6.7");
                    SetForegroundWindow(hWnd);
                    ACC1 = true;

                }
            }


                if (Keyboard.IsKeyDown(Key.F2))
            {
                LogBox.AppendText("Account #1");
                IntPtr hWnd = FindWindow(null, this.Personnage1TextBox.Text.ToString() +" -Dofus 2.57.6.7");
                SetForegroundWindow(hWnd);

            }
            if (Keyboard.IsKeyDown(Key.F3))
            {
                LogBox.AppendText("Account #2");
                IntPtr hWnd = FindWindow(null, this.Personnage2TextBox.Text.ToString() + " -Dofus 2.57.6.7");
                SetForegroundWindow(hWnd);
            }
            if (Keyboard.IsKeyDown(Key.F4))
            {
                LogBox.AppendText("Account #3");
                IntPtr hWnd = FindWindow(null, this.Personnage3TextBox.Text.ToString() + " -Dofus 2.57.6.7");
                SetForegroundWindow(hWnd);
            }
            if (Keyboard.IsKeyDown(Key.F5))
            {
                LogBox.AppendText("Account #4");
                IntPtr hWnd = FindWindow(null, this.Personnage4TextBox.Text.ToString()+" -Dofus 2.57.6.7");
                SetForegroundWindow(hWnd);

            }
        }
    }
}
 