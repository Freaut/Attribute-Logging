using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Attribute_Logging
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public class LogAttribute : Attribute
    {
        public void Log(string methodName, string message)
        {
            Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {methodName} - {message}");
        }
    }

    public static class Logger
    {
        public static void LogMethods(object obj)
        {
            Type type = obj.GetType();

            foreach (MethodInfo method in type.GetMethods())
            {
                foreach (LogAttribute attribute in method.GetCustomAttributes(typeof(LogAttribute), false))
                {
                    attribute.Log(method.Name, "Method executed.");
                    method.Invoke(obj, null);
                }
            }
        }
    }
}
