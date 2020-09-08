namespace Decorator
{
    public class AppendingBehavior : IStringBehavior
    {
        private IStringBehavior stringBehavior;

        public AppendingBehavior(IStringBehavior stringBehavior)
        {
            this.stringBehavior = stringBehavior;
        }

        public string Reverse(string input)
        {
            return this.stringBehavior.Reverse(input);
        }
    }
}
