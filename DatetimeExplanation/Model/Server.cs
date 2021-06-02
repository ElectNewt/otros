using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DatetimeExplanation.Model
{
    public class Server
    {
        public readonly string Name;
        //Lista timezones: https://docs.microsoft.com/en-us/previous-versions/windows/it-pro/windows-vista/cc749073(v=ws.10)?redirectedfrom=MSDN
        private readonly TimeZoneInfo _serverTimezone;
        public string PrintedValue;

        public Server(string name, string timezone)
        {
            Name = name;
            _serverTimezone = TimeZoneInfo.FindSystemTimeZoneById(timezone);
            PrintedValue = "";
        }

        public void DateTimeNow()
        {
            //https://stackoverflow.com/questions/6239976/how-to-set-a-time-zone-or-a-kind-of-a-datetime-value
            //Las siguientes dos líneas son para simular la ubicación del servidor.
            DateTime now = DateTime.Now;
            DateTime serverTime = TimeZoneInfo.ConvertTime(now, _serverTimezone);

            ImprimirValor(serverTime);
        }

        public void DateTimeUtcNow()
        {
            //da igual donde este el servidor, utc es siempre utc
            ImprimirValor(DateTime.UtcNow);
        }

        public void DateTimeUtcNowWithUserTimezone()
        {
            //añadimos a UtcNow la timezone del usuario (datetimeoffset)
            TimeZoneInfo timezone = TimeZoneInfo.FindSystemTimeZoneById(TimeZoneInfo.Local.Id);
            var utcOffset = new DateTimeOffset(DateTime.UtcNow, TimeSpan.Zero);
            DateTimeOffset userTime = utcOffset.ToOffset(timezone.GetUtcOffset(utcOffset));
            ImprimirValor(userTime);
        }

        void ImprimirValor(DateTime datetime)
        {
            using (new CultureScope(CultureInfo.GetCultureInfo("es-ES")))
            {
                PrintedValue = datetime.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            }
        }
        void ImprimirValor(DateTimeOffset datetime)
        {
            using (new CultureScope(CultureInfo.GetCultureInfo("es-ES")))
            {
                PrintedValue = datetime.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            }
        }


    }

}
