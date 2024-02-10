// See https://aka.ms/new-console-template for more information
using LogitechKeyLightConsole;
using LogitechKeyLightConsole.constants;
using LogitechKeyLightConsole.SDK;

Console.WriteLine("Hello, World!");

LogitechGSDK.LogiLedInit();

KeyHandler.Init();

//LogitechGSDK.LogiLedSetLightingForKeyWithScanCode(ConstantsKeys.Key_NumLock, 100, 0, 0);
