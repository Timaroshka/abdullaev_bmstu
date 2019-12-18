using System;

namespace lab1
{
    class Program
    {
        public static void input(ref double coef_res)
        {

            int number_of_digits = 0;
            int number_of_dots = 0;
            int number_of_minuses = 0;
            int count = 1;


            while (count != 0)
            {
                string Coef_str = Console.ReadLine();
                int length = Coef_str.Length;
                char[] Coef_char_array = Coef_str.ToCharArray();
                for (int i = 0; i < length; i++)
                {
                    if (Coef_char_array[i] == ',')
                    {
                        number_of_dots++;
                    }
                    if (Coef_char_array[i] == '-')
                    {
                        number_of_minuses++;
                    }
                    if (Char.IsDigit(Coef_char_array[i]))
                    {
                        number_of_digits++;
                    }
                }

                if ((number_of_digits != length && number_of_dots == 0 && number_of_minuses == 0) || (number_of_dots > 1) || (Coef_char_array[0] == ',') || (Coef_char_array[length - 1] == ',') || (length > 1 && Coef_char_array[0] == '0' && Coef_char_array[1] != ',') || (number_of_minuses > 1) || (number_of_minuses == 1 && Coef_char_array[0] != '-'))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Коэффициент введен некорректно!");
                    Console.ResetColor();
                    Console.WriteLine("Введите коэффициент повторно.");
                    input(ref coef_res);
                    count = 0;
                }
                else
                {
                    coef_res = Convert.ToDouble(Coef_str);
                    count = 0;
                }


            }
        }


        public static void FindSubradical(ref double A1, ref double B1, ref double C1, ref double PS, ref double NS)
        {
            double sub_r_neg = (-B1 - Math.Sqrt(B1 * B1 - 4 * A1 * C1)) / (2 * A1);
            double sub_r_pos = (-B1 + Math.Sqrt(B1 * B1 - 4 * A1 * C1)) / (2 * A1);
            PS = sub_r_pos;
            NS = sub_r_neg;
        }

        static void Main(string[] args)
        {
            Console.Title = "Абдуллаев Т.Х. гр.ИУ5-33Б";
            double PositiveSubradical = 0;
            double NegativeSubradical = 0;
            bool log_a = false;
            bool log_b = false;
            bool log_c = false;
            double A = 0;
            double B = 0;
            double C = 0;
            if (args != null && args.Length == 3)
            {
                log_a = double.TryParse(args[0], out A);
                log_b = double.TryParse(args[1], out B);
                log_c = double.TryParse(args[2], out C);
            }
            if (log_a == false || log_b == false || log_c == false)
            {
                Console.WriteLine("Введите коэффициент: А ");
                input(ref A);
                Console.WriteLine("Введите коэффициент: В ");
                input(ref B);
                Console.WriteLine("Введите коэффициент: С ");
                input(ref C);
            }
            double solution1 = 0;
            double solution2 = 0;
            double solution3 = 0;
            double solution4 = 0;
            FindSubradical(ref A, ref B, ref C, ref PositiveSubradical, ref NegativeSubradical);
            double Discriminant = 0;
            Discriminant = B * B - 4 * A * C;

            if ((PositiveSubradical < 0 && NegativeSubradical < 0) || (A == 0 && B <= 0 && C < 0) || (A == 0 && B >= 0 && C > 0) || Discriminant < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нет действительных корней!");
                Console.ResetColor();
            }

            if ((A == 0 && B == 0 && C == 0) || (A == 0 && C == 0 && B != 0))
            {
                solution1 = 0;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"x = {solution1}");
                Console.ResetColor();
            }

            if (PositiveSubradical == 0 && NegativeSubradical > 0)
            {
                solution1 = 0;
                solution2 = -Math.Sqrt(NegativeSubradical);
                solution3 = Math.Sqrt(NegativeSubradical);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"x1 = {solution1}, x2 = {solution2}, x3 = {solution3}");
                Console.ResetColor();
            }

            if (PositiveSubradical > 0 && NegativeSubradical == 0)
            {
                solution1 = 0;
                solution2 = -Math.Sqrt(PositiveSubradical);
                solution3 = Math.Sqrt(PositiveSubradical);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"x1 = {solution1}, x2 = {solution2}, x3 = {solution3}");
                Console.ResetColor();
            }

            if (A == 0 && B > 0 && C < 0)
            {
                solution1 = Math.Sqrt(-C / B);
                solution2 = -Math.Sqrt(-C / B);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"x1 = {solution1}, x2 = {solution2}");
                Console.ResetColor();
            }

            if (A != 0)
            {
                if (PositiveSubradical > 0 && NegativeSubradical > 0 && PositiveSubradical != NegativeSubradical)
                {
                    solution1 = -Math.Sqrt(PositiveSubradical);
                    solution2 = Math.Sqrt(PositiveSubradical);
                    solution3 = -Math.Sqrt(NegativeSubradical);
                    solution4 = Math.Sqrt(NegativeSubradical);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"x1 = {solution1}, x2 = {solution2}, x3 = {solution3}, x4 = {solution4}");
                    Console.ResetColor();
                }
                if (PositiveSubradical < 0 && NegativeSubradical > 0 || (PositiveSubradical == NegativeSubradical))
                {
                    solution1 = -Math.Sqrt(NegativeSubradical);
                    solution2 = Math.Sqrt(NegativeSubradical);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"x1 = {solution1}, x2 = {solution2}");
                    Console.ResetColor();
                }
                if (PositiveSubradical > 0 && NegativeSubradical < 0)
                {
                    solution1 = -Math.Sqrt(PositiveSubradical);
                    solution2 = Math.Sqrt(PositiveSubradical);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"x1 = {solution1}, x2 = {solution2}");
                    Console.ResetColor();
                }

            }
            Console.ReadLine();
        }
    }
}
