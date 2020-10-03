using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_core
{
    public class LoggerWrapper : ILogger
    {
        private User user;
        private ILogger logger;

        public LoggerWrapper(ILogger logger)
        {
            this.logger = logger;
        }

        public LoggerWrapper(ILogger logger, User user)
        {
            this.logger = logger;
            this.user = user;
        }

        public string log(User user,string message)
        {
            return logger.log($"Called by {user.getName()} - {message}");
        }

        public string log(string message)
        {
            if(user != null)
            {
                return log(user, message);
            }
            else
            {
                return logger.log(message);
            }
        }
    }
}
