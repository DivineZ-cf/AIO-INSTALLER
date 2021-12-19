using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Diagnostics;
using System.IO;
// VERY SIMPLE AIO INSTALLER
// CREDITS TO DIVINEZ#0286
// INSTALLS EVERYTHING YOUR COMPUTER NEEDS
// PLEASE DO NOT SELL 
// UPDATED TO LATEST FRAMEWORK
namespace AIO_Visual_Installer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        
            Console.ForegroundColor = ConsoleColor.White;
          
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to AIO Visual Installer - Created By DivineZ");
            Console.WriteLine("The Installer Takes 5 Minutes To Download All The Files!");
            Console.WriteLine("This Installs Both x86 and x64 Setups so Expect 2 Setups!");
            Console.WriteLine("Press 1 To Start The Installation");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Console.WriteLine("Please Choose Below!");
            var option = Console.ReadLine();
            if (option == "1")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Installing Visual C++ 2005.....");
                WebClient webClient = new WebClient();
                string text = @"C:\Windows\IME\2005_x64.EXE";   // WE ARE CREATING A STRING OF THE LOCATION THE FILE WILL BE DOWNLOADED TO
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/870081441051078736/921972773507715092/2005_x64.EXE", text); // WE DOWNLOAD THE FILE AND SET IT TO THAT LOCATION WE CREATED
                Process.Start(text);  //WE START THE FILE IN THE LOCATION DOWNLOADED
                Console.WriteLine("When Done With Setup Press ENTER to continue");
                var option2 = Console.ReadLine(); //empty no need for an if statement 
                string text2 = @"C:\Windows\IME\2005_x86.EXE";
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/870081441051078736/921973090504810566/2005_x86.EXE", text2); // SAME THING OVER AND OVER
                Process.Start(text2);
                Console.WriteLine("When Done With Setup Press ENTER to continue");
                var option3 = Console.ReadLine(); //empty no need for an if statement 
                Console.WriteLine("");
                Console.WriteLine("Visual C++ 2005 x64, 2005 x86 Completed");
                Console.WriteLine("");
                Console.WriteLine("Installing Visual C++ 2008.....");
                string text3 = @"C:\Windows\IME\2008_x64.exe";
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/870081441051078736/921973296642281492/2008_x64.exe", text3);
                Process.Start(text3);
                Console.WriteLine("When Done With Setup Press ENTER to continue");
                var option4 = Console.ReadLine(); //empty no need for an if statement 
                string text4 = @"C:\Windows\IME\2008_x86.exe";
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/870081441051078736/921973296281550869/2008_x86.exe", text4);
                Process.Start(text4);
                Console.WriteLine("When Done With Setup Press ENTER to continue");
                var option8 = Console.ReadLine(); //empty no need for an if statement 
                Console.WriteLine("");
                Console.WriteLine("Visual C++ 2008 x64, 2008 x86 Completed");
                Console.WriteLine("");
                Console.WriteLine("Installing Visual C++ 2010..... ");
                string text5 = @"C:\Windows\IME\2010_x64.exe";
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/870081441051078736/921973648267567104/2010_x64.exe", text5);
                Process.Start(text5);
                Console.WriteLine("When Done With Setup Press ENTER to continue");
                var option100 = Console.ReadLine(); //empty no need for an if statement 
                string text6 = @"C:\Windows\IME\2010_x86.exe";
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/870081441051078736/921973647638401024/2010_x86.exe", text6);
                Process.Start(text6);
                Console.WriteLine("When Done With Setup Press ENTER to continue");
                var option20 = Console.ReadLine(); //empty no need for an if statement 
                Console.WriteLine("");
                Console.WriteLine("Visual C++ 2010 x64, 2010 x86 Completed");
                Console.WriteLine("");
                Console.WriteLine("Installing Visual C++ 2012.....");
                string text7 = @"C:\Windows\IME\2012_x64.exe";
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/870081441051078736/921973998668087316/2012_x64.exe", text7);
                Process.Start(text7);
                Console.WriteLine("When Done With Setup Press ENTER to continue");
                var option50 = Console.ReadLine(); //empty no need for an if statement 
                string text8 = @"C:\Windows\IME\2012_x86.exe";
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/870081441051078736/921973998047354940/2012_x86.exe", text8);
                Process.Start(text8);
                Console.WriteLine("When Done With Setup Press ENTER to continue");
                var option30 = Console.ReadLine(); //empty no need for an if statement 
                Console.WriteLine("");
                Console.WriteLine("Completed Visual C++ 2012 x64, 2012 x86");
                Console.WriteLine("");
                Console.WriteLine("Installing Visual C++ 2013.....");
                string text9 = @"C:\Windows\IME\2013_x64.exe";
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/870081441051078736/921974356685520956/2013_x64.exe", text9);
                Process.Start(text9);
                Console.WriteLine("When Done With Setup Press ENTER to continue");
                var option40 = Console.ReadLine(); //empty no need for an if statement 
                string text10 = @"C:\Windows\IME\2013_x86.exe";
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/870081441051078736/921974357448871996/2013_x86.exe", text10);
                Process.Start(text10);
                Console.WriteLine("When Done With Setup Press ENTER to continue");
                var option90 = Console.ReadLine(); //empty no need for an if statement 
                Console.WriteLine("");
                Console.WriteLine("Completed Visual C++ 2013 x64, 2013 x86");
                Console.WriteLine("");
                Console.WriteLine("Installing Visual C++ 2015..... ");
                string text11 = @"C:\Windows\IME\2015_x64.exe";
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/870081441051078736/921974651977097226/2015_x64.exe", text11);
                Process.Start(text11);
                Console.WriteLine("When Done With Setup Press ENTER to continue");
                var option405 = Console.ReadLine(); //empty no need for an if statement 
                string text12 = @"C:\Windows\IME\2015_x86.exe";
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/870081441051078736/921974651159183370/2015_x86.exe", text12);
                Process.Start(text12);
                Console.WriteLine("When Done With Setup Press ENTER to continue");
                var option40005 = Console.ReadLine(); //empty no need for an if statement 
                Console.WriteLine("");
                Console.WriteLine("Completed Visual C++ 2015 x64, 2015 x86");
                Console.WriteLine("");
                Console.WriteLine("Installing Visual C++ 2017-2019.....");
                string text13 = @"C:\Windows\IME\2017-19_x64.exe";
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/870081441051078736/921974988163141672/2017-19_x64.exe", text13);
                Process.Start(text13);
                Console.WriteLine("When Done With Setup Press ENTER to continue");
                var option5000 = Console.ReadLine(); //empty no need for an if statement 
                string text14 = @"C:\Windows\IME\2017-19_x86.exe";
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/870081441051078736/921974987244584990/2017-19_x86.exe", text14);
                Process.Start(text14);
                Console.WriteLine("When Done With Setup Press ENTER to continue");
                var option9000000 = Console.ReadLine(); //empty no need for an if statement 
                Console.WriteLine("");
                Console.WriteLine("Completed Visual C++ 2017-19 x64, 2017-19 x86");
                Console.WriteLine("");
                Console.WriteLine("Installing Framework 4.8.....");
                string text15 = @"C:\Windows\IME\Framework_4.8.exe"; // latest framework update!
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/870081441051078736/921975567354581053/Framework_4.8.exe", text15);
                Process.Start(text15);
                Console.WriteLine("When Done With Setup Press ENTER to continue");
                var option900 = Console.ReadLine(); //empty no need for an if statement 
                Console.WriteLine("");
                Console.WriteLine("Completed Framework 4.8");
                Console.WriteLine("");
                Console.WriteLine("Installing Java.....");
                string text16 = @"C:\Windows\IME\JavaSetup8u311.exe";
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/870081441051078736/921975895391088710/JavaSetup8u311.exe", text16);
                Process.Start(text16);
                Console.WriteLine("When Done With Setup Press ENTER to continue");
                var option9000 = Console.ReadLine(); //empty no need for an if statement 
                Console.WriteLine("");
                File.Delete(text); // FROM HERE DOWN DELETES ALL THE SETUP FILES
                File.Delete(text2);
                File.Delete(text3);
                File.Delete(text4);
                File.Delete(text5);
                File.Delete(text6);
                File.Delete(text7);
                File.Delete(text8);
                File.Delete(text9);
                File.Delete(text10);
                File.Delete(text11);
                File.Delete(text12);
                File.Delete(text13);
                File.Delete(text14);
                File.Delete(text15);
                File.Delete(text16);
                Console.WriteLine("Installation Successfull! You may close it now!");
                Console.WriteLine("When Done With Setup Press ENTER to continue");
                var option900000 = Console.ReadLine(); //empty no need for an if statement 
                
            }
            else {
                Console.Clear();
                Console.WriteLine("Exiting");
            
            
            }
            
        }
    }
}
