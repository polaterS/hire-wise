using NpgsqlTypes;
using Serilog.Events;
using Serilog.Sinks.PostgreSQL;

namespace HireWise.API.Configurations.ColumnWriters
{
    public class EmailColumnWriter : ColumnWriterBase
    {
        public EmailColumnWriter() : base(NpgsqlDbType.Varchar)
        {
        }

        public override object GetValue(LogEvent logEvent, IFormatProvider formatProvider = null)
        {
            var (email, value) = logEvent.Properties.FirstOrDefault(p => p.Key == "email");
            return value?.ToString() ?? null;
        }
    }
}
