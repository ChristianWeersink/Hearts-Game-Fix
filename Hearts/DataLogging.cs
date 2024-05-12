using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hearts
{
    internal abstract class DataLogging
    {
        // with help from https://stackoverflow.com/questions/20185015/how-to-write-log-file-in-c

        /// <summary>
        /// path represetns a string of the path to write the log
        /// </summary>
        private static string path = string.Empty;
        /// <summary>
        /// Writes a message to the log using string logMessage
        /// </summary>
        /// <param name="logMessage"> is the message to write to log</param>
        
        public static void LogWrite(string logMessage, string filename)
        {
            path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
                using (StreamWriter w = File.AppendText(path + "\\" + filename))
                {
                    Log(logMessage, w, DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// uses txtWriter class to log a message to text file including date an formatting
        /// </summary>
        /// <param name="logMessage">Message to log</param>
        /// <param name="txtWriter">TextWriter object</param>
        public static void Log(string logMessage, TextWriter txtWriter, DateTime now)
        {
            try
            {
                txtWriter.Write("\r\nLog Entry : ");
                txtWriter.WriteLine("{0}", now.ToString() + " : " + logMessage);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.ToString()}");
            }
        }

        /// <summary>
        /// clear text file
        ///<param name = "filename" > file name to clear</param>
        /// </summary>
        public static void ClearLog(String filename)
        {
            try
            {
                path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                File.WriteAllText(path + "\\" + filename, string.Empty);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.ToString()}");
            }
        }


    }
}
