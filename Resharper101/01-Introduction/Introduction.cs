namespace Resharper101
{
    public class Introduction
    {
        // TODO: Configuration
        // TODO: Fix problems with Alt-Enter
        public static void NewCharAt(string input, int index, char newChar)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input is null");
            }

            char[] _chars = input.ToCharArray();
            _chars[index] = newChar;
            return new string(_chars);
        }
    }
}
