using System.Reflection;

namespace P02_BlackBoxInteger
{
    using System;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type type = typeof(BlackBoxInteger);
            var blackBoxInteger = (BlackBoxInteger)Activator.CreateInstance(type, true);
            var input = Console.ReadLine();
            while (input != "END")
            {
                var inputArgs = input.Split('_');
                var methodName = inputArgs[0];
                var methodParam = int.Parse(inputArgs[1]);
                var wantedMethod = type.GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);
                if (wantedMethod != null)
                {
                    wantedMethod.Invoke(blackBoxInteger, new object[] {methodParam});
                    var fieldName = "innerValue";
                    var innerFieldForPrint = type.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);
                    Console.WriteLine(innerFieldForPrint.GetValue(blackBoxInteger));

                }
                input =Console.ReadLine();
            }

        }
    }
}

