namespace LeetCode_Practice
{
    public class Logger {
        private Dictionary<string, int> _logger;
    
        public Logger() {
            _logger = new Dictionary<string,int>();
        }
        
        public bool ShouldPrintMessage(int timestamp, string message) {
            if (_logger.ContainsKey(message))
            {
                if (timestamp - _logger[message] >= 10)
                {
                    _logger[message] = timestamp;
                    return true;
                }
    
                return false;
            }
    
            _logger.Add(message, timestamp);
    
            return true;
        }
    }
    public class LoggerRateLimiter
    {
        [Fact]
        public void LoggerRateLimiter_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}