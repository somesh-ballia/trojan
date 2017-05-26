using Microsoft.Win32;

namespace ServerMain
{
    public class AutoStart
    {

        public enum MoveFileFlags
        {
            MOVEFILE_DELAY_UNTIL_REBOOT = 4,
        }

        [System.Runtime.InteropServices.DllImportAttribute("kernel32.dll", EntryPoint = "MoveFileEx")]
        public static extern bool MoveFileEx(string lpExistingFileName, string lpNewFileName, MoveFileFlags dwFlags);

        private const string RegLocation = @"Software\Microsoft\Windows\CurrentVersion\Run";
        
        public static void SetAutoStart(string keyName, string assemblyLocation)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(RegLocation);
            key.SetValue(keyName, assemblyLocation);
        }

        public static void UnSetAutoStart(string keyName)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(RegLocation);
            key.DeleteValue(keyName);
        }

        public static bool IsAutoStartEnabled(string keyName, string assemblyLocation)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(RegLocation);
            if (key == null)
                return false;
            string value = (string)key.GetValue(keyName);
            if (value == null)
                return false;
            return (value == assemblyLocation);
        }
    }
}
