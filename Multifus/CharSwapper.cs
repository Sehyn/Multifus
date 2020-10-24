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
    public partial class CharSwapper : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll")]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        public CharSwapper()
        {
            InitializeComponent();
        }

        private void Swap_Tick(object sender, EventArgs e)
        {
           

            if (Keyboard.IsKeyDown(Key.F2))
            {
                label2.Text = Parssing.Pers1;
                IntPtr hWnd = FindWindow(null, Parssing.Pers1.ToString() + " - Dofus 2.57.6.7");
                SetForegroundWindow(hWnd);

            }
            if (Keyboard.IsKeyDown(Key.F3))
            {
                label2.Text = Parssing.Pers2;
                IntPtr hWnd = FindWindow(null, Parssing.Pers2.ToString() + " - Dofus 2.57.6.7");
                SetForegroundWindow(hWnd);
            }
            if (Keyboard.IsKeyDown(Key.F4))
            {
                label2.Text = Parssing.Pers3;
                IntPtr hWnd = FindWindow(null, Parssing.Pers3.ToString() + " - Dofus 2.57.6.7");
                SetForegroundWindow(hWnd);
            }
            if (Keyboard.IsKeyDown(Key.F5))
            {
                label2.Text = Parssing.Pers4;
                IntPtr hWnd = FindWindow(null, Parssing.Pers4.ToString() + " - Dofus 2.57.6.7");
                SetForegroundWindow(hWnd);

            }
        }
    }
}
