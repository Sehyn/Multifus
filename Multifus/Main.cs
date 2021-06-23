using Multifus.Properties;
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
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private readonly KeysConverter keysConverter = new KeysConverter();

        private Keys hotkey1;
        private Keys hotkey2;
        private Keys hotkey3;
        private Keys hotkey4;


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
            this.Select();

        }

        private void ValidCharnamesBtn_Click(object sender, EventArgs e)
        {
            Personnage1TextBox.Enabled = false;
            Personnage2TextBox.Enabled = false;
            Personnage3TextBox.Enabled = false;
            Personnage4TextBox.Enabled = false;
            CharSwap.Enabled = true;

            //addded this part here to set the Window Names as soon as the button gets clicked
            Parssing.Pers1 = Personnage1TextBox.Text;
            Parssing.Pers2 = Personnage2TextBox.Text;
            Parssing.Pers3 = Personnage3TextBox.Text;
            Parssing.Pers4 = Personnage4TextBox.Text;

            this.Hide();
            CharSwapper SwapperForm = new CharSwapper();
            SwapperForm.ShowDialog();
            this.Close();

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }


        private int[] ConvertKeys(Keys hotkey)
        {
            int modifiers = 0;
            if (hotkey.HasFlag(Keys.Alt))
                modifiers |= 1;
            if (hotkey.HasFlag(Keys.Control))
                modifiers |= 2;
            if (hotkey.HasFlag(Keys.Shift))
                modifiers |= 4;

            int keys = (int)hotkey;
            keys &= ~(int)Keys.Alt;
            keys &= ~(int)Keys.Control;
            keys &= ~(int)Keys.Shift;

            return new int[] { modifiers, keys };
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();
                switch (id)
                {
                    case 0:
                        this.Activate();
                        LogBox.AppendText("Hotkey #1 - Pressed\r\n");
                        break;
                    case 1:
                        this.Activate();
                        LogBox.AppendText("Hotkey #2 - Pressed\r\n");
                        break;
                    case 2:
                        this.Activate();
                        LogBox.AppendText("Hotkey #3 - Pressed\r\n");
                        break;
                    case 3:
                        this.Activate();
                        LogBox.AppendText("Hotkey #4 - Pressed\r\n");
                        break;
                }
            }
        }
        private void RegisterGlobalHotkey(System.Windows.Forms.KeyEventArgs e, TextBox textBox, ref Keys hotkey, int id)
        {
            if (e.KeyData.HasFlag(Keys.LWin) || e.KeyData.HasFlag(Keys.RWin))
            {
                // Windows keys aren't really supported
                return;
            }

            if (e.KeyData == Keys.Escape)
            {
                // Unfocus the textbox by focusing on somethi ng else
                this.label1.Focus();
                return;
            }

            if (e.KeyData == Keys.Back)
            {
                // Clear / disable the hotkey
                UnregisterHotKey(this.Handle, id);
                textBox.Clear();
                return;
            }

            int modifiers = 0;
            if (e.Alt) // 262144
                modifiers |= 1;
            if (e.Control) // 131072
                modifiers |= 2;
            if (e.Shift) // 65536
                modifiers |= 4;

            UnregisterHotKey(this.Handle, id);
            RegisterHotKey(this.Handle, id, modifiers, (int)e.KeyCode);

            hotkey = e.KeyData;
            textBox.Text = keysConverter.ConvertToString(e.KeyData);
        }

        private void TxtHotkey1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            RegisterGlobalHotkey(e, TxtHotkey1, ref hotkey1, 0);

        }

        private void TxtHotkey2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            RegisterGlobalHotkey(e, TxtHotkey2, ref hotkey2, 1);

        }

        private void TxtHotkey3_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            RegisterGlobalHotkey(e, TxtHotkey3, ref hotkey3, 2);

        }

        private void TxtHotkey4_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            RegisterGlobalHotkey(e, TxtHotkey4, ref hotkey4, 3);

        }
        /*
I'm not sure what this method is for, but I guess that it isn't needed anymore. If you still need it, just implement the
keyboard hook here the same way as I did in CharSwapper.cs
*/

        /*
        private void CharSwap_Tick(object sender, EventArgs e)
        {
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

        */
    }
}
 