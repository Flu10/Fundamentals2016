namespace ExtensionMethods
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            i = i.RidicareLaPatrat();
            string value = "dot net tutorials";
            value = value.UppercaseFirstLetter();
            Console.WriteLine(value);
            Console.WriteLine(i);
            Console.ReadKey();
            
        }
    }

    public static class ExtensionMethods
    {
        public static int RidicareLaPatrat(this int value)
        {
            value = (int)Math.Pow(value,2);
            return value;
        
        }

        public static string UppercaseFirstLetter(this string value)
        {
            //
            // Uppercase the first letter in the string.
            //
            if (value.Length <= 0) return value;

            char[] array = value.ToCharArray();
            array[0] = char.ToUpper(array[0]);
            return new string(array);
        }
    }
}
