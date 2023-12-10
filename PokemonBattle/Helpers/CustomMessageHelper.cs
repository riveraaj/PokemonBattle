using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PokemonBattle.Helper {
    internal class CustomMessageHelper {
        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32.dll")]
        private static extern int EnableMenuItem(IntPtr hMenu, uint uIDEnableItem, uint uEnable);

        private const int MF_BYCOMMAND = 0x00000000;
        private const int SC_CLOSE = 0xF060;

        public static void Show(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon) {
            // Show the message box and obtain its handle.
            IntPtr messageBoxHandle = (IntPtr)MessageBox.Show(message, caption, buttons, icon);

            // Check if the handle is valid.
            if (messageBoxHandle != IntPtr.Zero) { 
                // Retrieve the system menu of the message box.
                IntPtr systemMenu = GetSystemMenu(messageBoxHandle, false);

                // Disable the close (X) button in the system menu.
                EnableMenuItem(systemMenu, SC_CLOSE, MF_BYCOMMAND | 0x1);
            }
        }
    }
}