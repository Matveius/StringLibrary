namespace StringLibrary
{
    public static class TextProcessor
    {
        public static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return new string(input.Reverse().ToArray());
        }

        public static int CountVowels(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            return input.ToLower().Count(c => vowels.Contains(c));
        }
    }
}
