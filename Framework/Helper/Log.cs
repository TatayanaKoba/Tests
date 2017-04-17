using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using Microsoft.SqlServer.Server;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Framework.GUI.Engine;


namespace Framework.Helper
{
    class Log
    {
        public static List<string> logmessagesfromfile = new List<string>();
        public static List<string> MessagestoLogFile = new List<string>();
        

        public static void CreateLogFolder()
        {
            string lol = @"C:\Users\Tatyana\Documents\Visual Studio 2015\Projects\Framework\Framework\bin\Debug";
            string path = System.IO.Path.Combine(lol, "Log");
            System.IO.Directory.CreateDirectory(path);
        }

        public static void CreateLogFolderforSeparateTest(string testname)
        {
            string lol = @"C:\Users\Tatyana\Documents\Visual Studio 2015\Projects\Framework\Framework\bin\Debug\Log";
            string path = System.IO.Path.Combine(lol, testname);
            System.IO.Directory.CreateDirectory(path);
        }

       public static void AddMessageToLogFile(string error)
        {
            string testname = Log.GetTestnNameDynamically();
            CreateLogFolder();
            CreateLogFolderforSeparateTest(testname);

            string Message = DateTime.Now + " " + error;
            string path = @"C:\Users\Tatyana\Documents\Visual Studio 2015\Projects\Framework\Framework\bin\Debug\Log\" + testname;
            using (StreamWriter w = File.AppendText(path + "\\log" + DateTime.Now.ToString("yyyy-MM-dd--hh-mm") + ".txt"))
                {
                    w.WriteLine(Message);
                }
        }


        public static bool InitiateLogging(string testname)
        {
            CreateLogFolder();
            CreateLogFolderforSeparateTest(testname);
            return true;
        }

        public static string GetTestnNameDynamically()
        {
            StackTrace stackTrace = new StackTrace();           // get call stack
            StackFrame[] stackFrames = stackTrace.GetFrames();  // get method calls (frames)

            List<String> methods = new List<string>();
            // write call stack method names
            foreach (StackFrame stackFrame in stackFrames)
            {
                string lolka = stackFrame.GetMethod().Name;
                //if (!lolka.Contains("Run") || !lolka.Contains("Sync") || !lolka.Contains("Invoke") || !lolka.Contains("Get") ||  )
                //{

                //}

                methods.Add(lolka);
                Console.WriteLine(stackFrame.GetMethod().Name);   // write method name
            }
            int i = methods.IndexOf("InvokeMethod");
            return methods[i - 1];
        }


        public static void CreateScreenshotsFolder()
        {
            string lol = @"C:\Users\Tatyana\Documents\Visual Studio 2015\Projects\Framework\Framework\bin\Debug";
            string path = System.IO.Path.Combine(lol, "Screenshots");
            System.IO.Directory.CreateDirectory(path);
        }
        public static void Screenshot()
        {
            CreateScreenshotsFolder();
            string lol = @"C:\Users\Tatyana\Documents\Visual Studio 2015\Projects\Framework\Framework\bin\Debug\Screenshots";
            var ssdriver = Browser.driver as ITakesScreenshot;
            var screenshot = ssdriver.GetScreenshot();
            screenshot.SaveAsFile(lol + "\\Scr" + DateTime.Now.ToString("yyyy-MM-dd--hh-mm-ss") + ".png", ImageFormat.Png);
        }

        public static void LogSystemInfo(string testname, string error)
        {
            string filename = GetFileNameToWrite(testname);


            string Message = DateTime.Now + " " + error;
            string path = @"C:\Users\Tatyana\Documents\Visual Studio 2015\Projects\Framework\Framework\bin\Debug\Log\" + testname;

            using (StreamWriter w = File.AppendText(path + "\\" + filename))
            {
                w.WriteLine(Message);
            }
        }

        public static string GetFileNameToWrite(string logDirectory)
        {
            var directory = new DirectoryInfo(@"C:\Users\Tatyana\Documents\Visual Studio 2015\Projects\Framework\Framework\bin\Debug\Log\" + logDirectory);
            var myFile = (from f in directory.GetFiles()
                          orderby f.LastWriteTime descending
                          select f).First();
            return myFile.Name;
        }
    }
}
