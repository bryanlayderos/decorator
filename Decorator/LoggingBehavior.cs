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
            this.logger.Log(input);
            return this.stringBehavior.Reverse(input);
        }
    }
}
