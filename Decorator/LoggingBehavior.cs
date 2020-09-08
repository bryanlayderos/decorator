namespace Decorator
{
    public class LoggingBehavior : IStringBehavior
    {
        private IStringBehavior stringBehavior;
        private DebugLogger logger;

        public LoggingBehavior(IStringBehavior stringBehavior)
        {
            this.stringBehavior = stringBehavior;
            this.logger = new DebugLogger();
        }

        public string Reverse(string input)
        {
            return this.stringBehavior.Reverse(input);
        }

        public void Log(string input)
        {
            this.logger.Log(input);
        }
    }
}
