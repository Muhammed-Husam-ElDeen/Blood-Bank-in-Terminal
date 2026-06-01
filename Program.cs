using System.Globalization;
using Valid_Rep;

namespace Valid_Rep
{
    class Valid
    {
        public static void warn(int number_of_Tries)
        {
            int warn = number_of_Tries;
            warn--;
            Console.WriteLine("========================================");
            Console.WriteLine($"WARNING: You have {warn} tries remaining.");
            Console.WriteLine("========================================");
            if (warn == 0)
            {
                Console.WriteLine("=== Terminating: Too many failed attempts ===");
                Environment.Exit(1);
            }
        }
        public static int Readint()
        {
            int input;
            int num = 5;
            while (num != 0)
            {
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    return input;
                    break;
                }
                catch (FormatException)
                {
                    num--;
                    Console.WriteLine("--- Input Error ---");
                    Console.WriteLine($"Please enter a valid whole number. {num} tries remaining.");
                    Console.WriteLine("-------------------");
                    if (num == 0)
                    {
                        Console.WriteLine("=== Terminating: Too many failed attempts ===");
                        Environment.Exit(1);
                        return -1;
                    }

                }
            }
            return 0;
        }
        public static bool ReadBoolean()
        {
            bool input;
            int num = 5;
            while (num != 0)
            {
                try
                {
                    input = Convert.ToBoolean(Console.ReadLine().ToLower());
                    return input;
                    break;
                }
                catch (FormatException e)
                {
                    num--;
                    Console.WriteLine("--- Input Error ---");
                    Console.WriteLine($"Please enter 'true' or 'false'. {num} tries remaining.");
                    Console.WriteLine("-------------------");
                    if (num == 0)
                    {
                        Console.WriteLine("=== Terminating: Too many failed attempts ===");
                        Environment.Exit(1);
                    }
                }
            }
            return false;
        }
        public static Char ReadCharUpper()
        {
            char input;
            int num = 5;
            while (true)
            {
                try
                {
                    input = Convert.ToChar(Console.ReadLine().ToUpper());
                    return input;
                    break;
                }
                catch (FormatException e)
                {
                    num--;
                    Console.WriteLine("--- Input Error ---");
                    Console.WriteLine($"Please enter a single letter (A-Z). {num} tries remaining.");
                    Console.WriteLine("-------------------");
                    if (num == 0)
                    {
                        Console.WriteLine("=== Terminating: Too many failed attempts ===");
                        Environment.Exit(1);
                    }
                }
            }
            return ' ';
        }

        public static double ReadDouble()
        {
            double input;
            int num = 5;
            while (true)
            {
                try
                {
                    input = Convert.ToDouble(Console.ReadLine());
                    return input;
                    break;
                }
                catch (FormatException e)
                {
                    num--;
                    Console.WriteLine("--- Input Error ---");
                    Console.WriteLine($"Please enter a numeric value. {num} tries remaining.");
                    Console.WriteLine("-------------------");
                    if (num == 0)
                    {
                        Console.WriteLine("=== Terminating: Too many failed attempts ===");
                        Environment.Exit(1);
                    }
                }
            }
            return -1;
        }
        public static string ReadStringLower()
        {
            string word;
            int num = 5;
            while (true)
            {
                word = Console.ReadLine().ToLower();
                if (string.IsNullOrWhiteSpace(word))
                {
                    num--;
                    Console.WriteLine("--- Empty Input ---");
                    Console.WriteLine($"No input detected. Please try again. ({num} tries remaining)");
                    Console.WriteLine("--------------------");
                    if (num == 0)
                    {
                        Console.WriteLine("=== Terminating: Too many failed attempts ===");
                        Environment.Exit(1);
                    }
                }
                else { return word; break; }
            }
        }
        public static string ReadStringUpper()
        {
            String word;
            int num = 5;
            while (true)
            {
                word = Console.ReadLine().ToUpper();
                if (string.IsNullOrWhiteSpace(word))
                {
                    num--;
                    Console.WriteLine("--- Empty Input ---");
                    Console.WriteLine($"No input detected. Please try again. ({num} tries remaining)");
                    Console.WriteLine("--------------------");
                    if (num == 0)
                    {
                        Console.WriteLine("=== Terminating: Too many failed attempts ===");
                        Environment.Exit(1);
                    }
                }
                else { return word; break; }
            }
        }

    }
    class rep
    {
        public static void positive_double(ref double num)
        {
            int warn = 5;
            while (num < 0)
            {
                Console.WriteLine("only positives sir please for crying out loud");
                Valid.warn(warn);
                num = Valid.ReadDouble();
            }
        }
        public static void array_print_1D<T>(T[] array)
        {
            System.Console.Write("{");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            System.Console.WriteLine(" }");
        }
        public static int index_finder_string(string[] array, string variable)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (variable == array[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }

}

namespace Programm
{
    class Blood
    {
        string name = "";
        string type = "";
        int ID = 0;
        double amount = 0.4;
        static List<string> names = new();
        static List<double> record_amounts = new();
        static List<int> IDs = new();
        static List<string> Types = new();
        static Dictionary<string, double> blood = new();

        static Dictionary<string, string[]> transfusion = new()
        {
            { "A+",  new[] { "A+", "A-", "O+", "O-" } },
            { "A-",  new[] { "A-", "O-" } },
            { "B+",  new[] { "B+", "B-", "O+", "O-" } },
            { "B-",  new[] { "B-", "O-" } },
            { "AB+", new[] { "AB+", "AB-", "A+", "A-", "B+", "B-", "O+", "O-" } },
            { "AB-", new[] { "AB-", "A-", "B-", "O-" } },
            { "O+",  new[] { "O+", "O-" } },
            { "O-",  new[] { "O-" } },
        };

        public static string[] types = { "A+", "A-", "B-", "B+", "AB+", "AB-", "O+", "O-" };
        public Blood(string name, string type)
        {
            Random random = new();
            this.ID = random.Next(10000, 100000);
            this.name = name;
            blood[type] += 0.4;
            names.Add(name);
            IDs.Add(ID);
            record_amounts.Add(amount);
            Types.Add(type);
        }
        public static void populate()
        {
            blood.Add("O-", 0);
            blood.Add("O+", 0);
            blood.Add("A-", 0);
            blood.Add("A+", 0);
            blood.Add("B-", 0);
            blood.Add("B+", 0);
            blood.Add("AB-", 0);
            blood.Add("AB+", 0);
        }

        public static void take(string type, double amount)
        {
            bool flag = false;
            for (int i = 0; i < transfusion[type].Length; i++)
            {
                string index = transfusion[type][i];
                if (blood[index] >= amount)
                {
                    flag = true;
                    blood[index] -= amount;
                    Console.WriteLine("Blood Successfully occupied, ready for transfusion");
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Sorry,no available Blood Brother");
            }
        }
        public static void view_Recorsd()
        {
            for (int i = 0; i < names.Count(); i++)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"Donor's name -> {names[i]}");
                Console.WriteLine($"ID of Donation -> {IDs[i]}");
                Console.WriteLine($"Blood Type -> {Types[i]}");
                Console.WriteLine($"Amount Withdrawn -> {record_amounts[i]}");
                Console.WriteLine("------------------------------------------");
            }
        }
        public static void view()
        {
            Console.Write("{ ");
            foreach (string typee in types)
            {
                Console.Write(typee);
            }
            Console.WriteLine(" }");
        }
    }
    public class Programm
    {
        static void Main(string[] args)
        {
            Blood.populate();
            while (true)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("=      Welcome to the Blood Bank App    =");
                Console.WriteLine("========================================");
                Console.WriteLine("Please choose an action:");
                Console.WriteLine("========================================");
                Console.WriteLine("1 = Donate");
                Console.WriteLine("2 = Take");
                Console.WriteLine("3 = View Records");
                Console.WriteLine("========================================");
                Console.Write("Enter choice: ");
                int choice = Valid.Readint();
                if (choice == 1)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("=                 DONATE               =");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Enter your name");
                    string name = Valid.ReadStringLower();
                    Console.WriteLine("Enter your Blood Type");
                    string type = Valid.ReadStringUpper();
                    while (rep.index_finder_string(Blood.types, type) == -1)
                    {
                        Valid.warn(3);
                        Console.WriteLine("Invalid Blood Type");
                        Blood.view();
                    }
                    Blood blood = new(name, type);
                    Console.WriteLine("========================================");
                    Console.WriteLine("=   Donation successful — Thank you!   =");
                    Console.WriteLine("========================================");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("=                 REQUEST               =");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Enter your blood type");
                    string type = Valid.ReadStringUpper();
                    while (rep.index_finder_string(Blood.types, type) == -1)
                    {
                        Valid.warn(3);
                        Console.WriteLine("Invalid Blood Type");
                        Blood.view();
                    }
                    Console.WriteLine("Now enter the amount you need (in Liters)");
                    double amount = Valid.ReadDouble();
                    rep.positive_double(ref amount);
                    Blood.take(type, amount);
                }
                else if (choice == 3)
                {
                    Blood.view_Recorsd();
                }
                else
                {
                    Console.WriteLine("Invalid Choice, try again");
                }
            }
        }
    }
}