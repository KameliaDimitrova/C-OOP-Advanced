using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace P01_HarvestingFields
{
    using System;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            Type harvesterType = typeof(HarvestingFields);
            var wantedFields = harvesterType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            var fieldModifier = "";
            while (input != "HARVEST")
            {
                fieldModifier = input;
                switch (fieldModifier)
                {
                    case "private":
                        Console.WriteLine(PrintFields(wantedFields.Where(x => x.IsPrivate).ToArray()));
                        break;
                    case "protected":
                        Console.WriteLine(PrintFields(wantedFields.Where(x => x.IsFamily).ToArray()));
                        break;
                    case "public":
                        Console.WriteLine(PrintFields(wantedFields.Where(x => x.IsPublic).ToArray()));
                        break;
                    case "all":
                        Console.WriteLine(PrintFields(wantedFields));
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }

        }

        private static string PrintFields(FieldInfo[] wantedFields)
        {
            var sb = new StringBuilder();
            foreach (var field in wantedFields)
            {
                var modifier = field.Attributes.ToString().ToLower();
                if (modifier == "family")
                    modifier = "protected";
                sb.AppendLine($"{modifier} {field.FieldType.Name} {field.Name}");
            }
            return sb.ToString().Trim();
        }
    }
}
