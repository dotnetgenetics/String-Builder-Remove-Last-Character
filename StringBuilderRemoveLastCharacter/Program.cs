using System.Text;

namespace StringBuilderRemoveLastCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remove Last Character");
            RemoveLastCharacter();
            Console.WriteLine("\n\nRemove Last Character Using Length");
            RemoveLastCharacterUsingLength();
            Console.ReadLine();
        }

        private static void RemoveLastCharacter()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit,");
            sb.AppendLine("sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
            Console.WriteLine(sb.ToString());
            sb = sb.Remove(sb.Length - 3, 3);
            Console.WriteLine(sb.ToString());
        }

        private static void RemoveLastCharacterUsingLength()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit,");
            sb.AppendLine("sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
            Console.WriteLine(sb.ToString());
            sb.Length -= 3;
            Console.WriteLine(sb.ToString());
        }
    }
}