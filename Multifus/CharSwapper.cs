using MouseKeyboardLibrary;
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

namespace Multifus
{
    public partial class CharSwapper : Form
    {
      

        private KeyboardHook _keyboardHook;

        public CharSwapper()
        {
            InitializeComponent();

            InitializeKeyboardHook(); //calls the method beneath to init the Hook
        }

        private void InitializeKeyboardHook()
        {
            _keyboardHook = new KeyboardHook(); //initialize
            _keyboardHook.KeyUp += new KeyEventHandler(HandleKeyUp); //assign event: when a key gets pressed, call this method
            _keyboardHook.Start();
        }

        private void HandleKeyUp(object sender, KeyEventArgs e)
        {
            //this gets called automatically by the KeyboardHook when ANY key is released
            // e contains the event information
            var pressedKey = e.KeyCode;

            /*
            It would be better practice to use a "switch statement" (https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch)
            instead of if and else here, but I kept it like that.
            */

            if (pressedKey == Keys.F2)
            {
                label2.Text = Parssing.Pers1;
                IntPtr hWnd = Native.FindWindow(null, Parssing.Pers1.ToString() + "- Dofus 2.57.8.11");

                ForegroundWindowBypass.Set(hWnd);
            }
            else if(pressedKey == Keys.F3)
            {
                label2.Text = Parssing.Pers2;
                IntPtr hWnd = Native.FindWindow(null, Parssing.Pers2.ToString() + "- Dofus 2.57.8.11");

                ForegroundWindowBypass.Set(hWnd);
            }
            else if(pressedKey == Keys.F4)
            {
                label2.Text = Parssing.Pers3;
                IntPtr hWnd = Native.FindWindow(null, Parssing.Pers3.ToString() + "- Dofus 2.57.8.11");
                ForegroundWindowBypass.Set(hWnd);
            }
            else if(pressedKey == Keys.F5)
            {
                label2.Text = Parssing.Pers4;
                IntPtr hWnd = Native.FindWindow(null, Parssing.Pers4.ToString() + "- Dofus 2.57.8.11");
                ForegroundWindowBypass.Set(hWnd);
            }
            
        }


        //This is not needed anymore
        /*private void Swap_Tick(object sender, EventArgs e)
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
        }*/ 
    }
}
