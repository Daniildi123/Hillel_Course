using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace UkrainianStringUtilsLibrary
{
    public static class UkrainianStringUtils
    {
        private static readonly char[] Vowels = { 'а', 'е', 'є', 'и', 'і', 'ї', 'о', 'у', 'ю', 'я' };
        private static readonly char[] Consonants = { 'б', 'в', 'г', 'ґ', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };

        public static int CountVowels(string input)
        {
            return input.ToLower().Count(c => Vowels.Contains(c));
        }

        public static int CountConsonants(string input)
        {
            return input.ToLower().Count(c => Consonants.Contains(c));
        }

        public static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string RemoveDuplicates(string input)
        {
            return new string(input.ToCharArray().Distinct().ToArray());
        }

        public static string RemovePunctuation(string input)
        {
            return Regex.Replace(input, @"[^\w\s]", "");
        }
     
    }
}
