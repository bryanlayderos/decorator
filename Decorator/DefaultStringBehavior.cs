namespace Decorator
{
    using System;

    public class DefaultStringBehavior : IStringBehavior
    {
        public string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}