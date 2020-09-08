namespace Decorator
{
    public class AppendingBehavior : IStringBehavior
    {
        private readonly string space = " ";
        private IStringBehavior stringBehavior;
        
        public AppendingBehavior(IStringBehavior stringBehavior)
        {
            this.stringBehavior = stringBehavior;
        }

        public string Reverse(string input)
        {
            return this.stringBehavior.Reverse(input) + this.space + input;
        }
    }
}