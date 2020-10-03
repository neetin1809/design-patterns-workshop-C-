//tag::source[]
namespace Anticorruption_core
{
    public class LoggerWrapper : ILogger
    {
        private User user;
        private LoggerV2 logger;

        public LoggerWrapper(LoggerV2 logger)
        {
            this.logger = logger;
        }

        public LoggerWrapper(LoggerV2 logger, User user)
        {
            this.logger = logger;
            this.user = user;
        }

        public string log(User user,string message)
        {
            return logger.logMessage($"Called by {user.getName()} - {message}");
        }

        public string log(string message)
        {
            if(user != null)
            {
                return log(user, message);
            }
            else
            {
                return logger.logMessage(message);
            }
        }
    }
}
//tag::end[]