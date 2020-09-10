namespace Decorator
{
    public class LoggingBehavior : IStringBehavior
    {
        private readonly IStringBehavior stringBehavior;
        private readonly ILogger logger;

        public LoggingBehavior(IStringBehavior stringBehavior, ILogger logger)
        {
            this.stringBehavior = stringBehavior;
            this.logger = logger;
        }

        public string Reverse(string input)
        {
            string reverse = this.stringBehavior.Reverse(input);
            this.logger.Log(reverse);

            return reverse;
        }
    }
}