using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using LogitechKeyLightConsole.constants;
using LogitechKeyLightConsole.SDK;

namespace LogitechKeyLightConsole
{
    public class KeyHandler
    {
        [DllImport("user32.dll")]
        static extern short GetKeyState(int keyCode);

        const int VK_SCROLL = 0x91; // Scroll Lock
        const int VK_NUMLOCK = 0x90; // Num Lock
        const int VK_CAPITAL = 0x14; // Caps Lock

        public static void Init()
        {
            Console.WriteLine("Press any key to exit...");

            while (!Console.KeyAvailable)
            {
                // Check the state of the Scroll Lock key
                if ((GetKeyState(VK_SCROLL) & 1) == 1)
                {
                    Console.WriteLine("Scroll Lock is ON");
                    // Call your method for Scroll Lock being toggled ON
                }
                else
                {
                    Console.WriteLine("Scroll Lock is OFF");
                    // Call your method for Scroll Lock being toggled OFF
                }

                // Check the state of the Num Lock key
                if ((GetKeyState(VK_NUMLOCK) & 1) == 1)
                {
                    LogitechGSDK.LogiLedSetLightingForKeyWithScanCode(ConstantsKeys.Key_NumLock, 0, 100, 0);
                    Console.WriteLine("Num Lock is ON");
                    // Call your method for Num Lock being toggled ON
                }
                else
                {
                    LogitechGSDK.LogiLedSetLightingForKeyWithScanCode(ConstantsKeys.Key_NumLock, 100, 0, 0);
                    Console.WriteLine("Num Lock is OFF");
                    // Call your method for Num Lock being toggled OFF
                }

                // Check the state of the Caps Lock key
                if ((GetKeyState(VK_CAPITAL) & 1) == 1)
                {
                    Console.WriteLine("Caps Lock is ON");
                    // Call your method for Caps Lock being toggled ON
                }
                else
                {
                    Console.WriteLine("Caps Lock is OFF");
                    // Call your method for Caps Lock being toggled OFF
                }

                Thread.Sleep(1000); // Pause for 1 second
            }
        }
    }
}
