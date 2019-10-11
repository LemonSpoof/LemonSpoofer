using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32;
namespace Lemon
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Lemon Spoofer";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("[1] Spoof");
            Console.WriteLine("[2] Clean");
            Console.WriteLine("Made by Lemon Squad [JUICY]");
            string a = Console.ReadLine();
            if (a == "1")
            {
                Program.Spoof();
            }
            if (a == "2")
            {
                Program.Spoof();
            }
            if (a == "Lemon")
            {
                Program.Spoof();
            }
        }
        public static void Spoof()
        {
            Console.Clear();
            Outbuilt.Protection.FreezeMouse();
            Console.WriteLine("[*] Cleaning");
            SerialsClean.Download1();
            SerialsClean.Download2();
            SerialsClean.Clean();
            Console.WriteLine("[*] Mapping Driver");
            SerialsClean.Spoof();
            Console.WriteLine("[*] Resetting Adapters...");
            SerialsClean.Adapters();
            Console.WriteLine("[*] Spoofing MAC Address..");
            SerialsClean.MAC();
            SerialsClean.no();
            SerialsClean.restart();
            Console.WriteLine("[*] Success Spooofed Have Fun Playing Fortnite");
            Thread.Sleep(3000);
            Console.WriteLine("[*] Finishing Touches...");
            Thread.Sleep(7000);
            SerialsClean.Spofy();
            SerialsClean.ok();
            SerialsClean.Stall();
            Thread.Sleep(7000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[*] Closing...");
            Thread.Sleep(2000);
            Outbuilt.Protection.ReleaseMouse();
        }
    }
}
