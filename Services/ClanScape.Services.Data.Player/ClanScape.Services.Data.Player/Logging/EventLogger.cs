using ClanScape.Services.Data.Player.Interfaces;
using ClanScape.Shared.General;
using System.Diagnostics;

namespace ClanScape.Services.Data.Player.Logging
{
    public class EventLogger : ILogger
    {
        private EventLog _logger => new EventLog
        {
            Source = Constants.EVENT_LOGGING_SOURCE,
            Log = Constants.EVENT_LOGGING_LOG_SERVICES_PLAYER
        };

        public EventLogger()
        {
            if (!EventLog.SourceExists(Constants.EVENT_LOGGING_SOURCE))
                EventLog.CreateEventSource(Constants.EVENT_LOGGING_SOURCE, Constants.EVENT_LOGGING_LOG_SERVICES_PLAYER);
        }

        public void Log(string message)
        {
            _logger.WriteEntry(message);
        }
    }
}
