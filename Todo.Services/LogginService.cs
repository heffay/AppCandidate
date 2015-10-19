using System;
using System.IO;
using System.Text;

namespace Todo.Services
{
    public class LogginService
    {
        public void Error(string message, Exception ex = null)
        {
            var builder = new StringBuilder();
            using (var file = new StreamWriter(AssemblyDirectory +  @"\log.txt"))
            {
                file.WriteLine("ERROR  " + message);
                if (ex != null)
                {
                    file.WriteLine(FlattenException(ex, builder).ToString());
                }
            }
        }
        public void Warn(string message, Exception ex = null)
        {
            var builder = new StringBuilder();
            using (var file = new StreamWriter(AssemblyDirectory + @"\log.txt"))
            {
                file.WriteLine("WARN" + message);
                if (ex != null)
                {
                    file.WriteLine(FlattenException(ex, builder).ToString());
                }
            }
        }

        public void Info(string message)
        {
            using (var file = new StreamWriter(AssemblyDirectory + @"\log.txt"))
            {
                file.WriteLine("INFO " + message);
               
            }
        }

        public void Debug(string message)
        {
            using (var file = new StreamWriter(AssemblyDirectory + @"\log.txt"))
            {
                file.WriteLine("DEBUG " + message);
                
            }
        }

        private StringBuilder FlattenException(Exception ex, StringBuilder builder)
        {
            //TODO code this to get all the exception info, including inner exception information

            return builder;
        }

        private static string AssemblyDirectory
        {
            get { return AppDomain.CurrentDomain.BaseDirectory; }
        }
    }
}
