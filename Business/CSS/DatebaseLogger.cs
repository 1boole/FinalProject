using System;

namespace Business.CSS
{
    public class DatebaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglangı");
        }
    }
}
