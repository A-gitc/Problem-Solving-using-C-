namespace Task1_Week1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
  * Write a program that takes two integers then prints the power.
  */
            #region Q11
            Console.Write("Enter Two numbers The Second One is the power: ");
            char[] numbers = Console.ReadLine().ToArray();
            int numberQ11a = Convert.ToInt32(numbers[0]), numberQ11b = Convert.ToInt32(numbers[1]);

            Console.WriteLine($"The result of {numberQ11a} Power {numberQ11b} = {numberQ11a ^ numberQ11b}");
            #endregion

            /*
 * Write a program to enter marks of five subjects and calculate total, average and percentage.
 */
            #region Q12 
            Console.Write("Enter Marks of five subjects (Space between them): ");
            List<int> marks = Console.ReadLine().Split().Select(s => int.Parse(s)).ToList();
            Console.WriteLine($"Total marks: {marks.Sum()}");
            Console.WriteLine($"Average Marks: {marks.Average()}");
            Console.WriteLine($"Percentage: {marks.Sum()}%");
            #endregion

            /*
 * Write a program to input the month number and print the number of days in that month.
 */
            #region Q13
            Console.Write("Month Number: ");
            int MonthNumber = Convert.ToInt32(Console.ReadLine());
            switch (MonthNumber)
            {
                case 1:
                    Console.WriteLine(31);
                    break;
                case 2:
                    Console.WriteLine(28);
                    break;
                case 3:
                    Console.WriteLine(30);
                    break;
                case 4:
                    Console.WriteLine(31);
                    break;
                case 5:
                    Console.WriteLine(30);
                    break;
                case 6:
                    Console.WriteLine(31);
                    break;
                case 7:
                    Console.WriteLine(30);
                    break;
                case 8:
                    Console.WriteLine(31);
                    break;
                case 9:
                    Console.WriteLine(30);
                    break;
                case 10:
                    Console.WriteLine(31);
                    break;
                case 11:
                    Console.WriteLine(30);
                    break;
                case 12:
                    Console.WriteLine(31);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            #endregion

            /*
 * Write a program to input marks of five subjects Physics, Chemistry, Biology, Mathematics and Computer, And Calculate percentage and grade.
 * Solution:
 *      first we need 5 list, for each subject list and then we list user to enter 5 marks for everySubject and then show the marks and grade for each subject
 */
            #region Q14
            string[] subject = { "Physics", "Chemistry", "Biology", "Mathematics", " Computer" };
            double[] mark = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter Five marks of {subject[i]}");
                switch (subject[i])
                {
                    case "Physics":
                        mark[i] = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList().Average();
                        break;
                    case "Chemistry":
                        mark[i] = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList().Average();
                        break;
                    case "Biology":
                        mark[i] = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList().Average();
                        break;
                    case "Mathematics":
                        mark[i] = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList().Average();
                        break;
                    case "Computer":
                        mark[i] = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList().Average();
                        break;
                    default:
                        Console.WriteLine("Inavalid Input");
                        break;

                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (mark[i] >= 90)
                {
                    Console.WriteLine($"The Grade of {subject[i]} IS: A");
                }
                else if (mark[i] >= 80)
                {
                    Console.WriteLine($"The Grade of {subject[i]} IS: B");
                }
                else if (mark[i] >= 70)
                {
                    Console.WriteLine($"The Grade of {subject[i]} IS: C");
                }
                else if (mark[i] >= 60)
                {
                    Console.WriteLine($"The Grade of {subject[i]} IS: D");
                }
                else if (mark[i] >= 40)
                {
                    Console.WriteLine($"The Grade of {subject[i]} IS: E");
                }
                else
                {
                    Console.WriteLine($"The Grade of {subject[i]} IS: F");
                }
            }
            #endregion

            /*
 * Write a program to check whether a number is positive or negative or zero.
 */
            #region Q15

            Console.Write("Enter a Number: ");

            int numberQ15 = Convert.ToInt32(Console.ReadLine());

            if (numberQ15 < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else if (numberQ15 > 0)
            {
                Console.WriteLine("the number is positive");
            }
            else
            {
                Console.WriteLine("The number is Zero");
            }
            #endregion

            /*
 * Write a program to create a Simple Calculator.
 */
            #region Q16

            string[] operation = { "Addition", "Subtraction", " Multiplication", " Division" };
            Console.WriteLine("Enter the Nubmer of Operatoin you want to apply(1-4): ");
            for (int i = 0; i < operation.Length; i++)
            {
                Console.WriteLine($"{i}. {operation[i]}");
            }
            Console.Write("Enter Number: ");
            int choise = int.Parse(Console.ReadLine());
            if (choise < 1 || choise > operation.Length)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                Console.Write("Enter First Operand: ");
                double first_operand = double.Parse(Console.ReadLine());
                Console.Write("Enter Second Operand: ");
                double Second_operand = double.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Console.WriteLine($"The result of {first_operand} + {Second_operand}={first_operand + Second_operand}");
                        break;
                    case 2:
                        Console.WriteLine($"The result of {first_operand} - {Second_operand}={first_operand - Second_operand}");
                        break;
                    case 3:
                        Console.WriteLine($"The result of {first_operand} * {Second_operand}={first_operand * Second_operand}");
                        break;
                    case 4:
                        Console.WriteLine($"The result of {first_operand} / {Second_operand}={first_operand / Second_operand}");
                        break;
                }
            }
            #endregion

            /*
 * Write a program to allow the user to enter a string and print the REVERSE of it.
 */
            #region Q17

            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            foreach (char item in word.Reverse())
            {
                Console.Write(item);
            }

            #endregion

            /*
 * Write a program to allow the user to enter int and print the REVERSED of it.
 */

            #region Q18
            Console.Write("Enter a a number: ");
            int numberQ18 = int.Parse(Console.ReadLine());



            #endregion

            /*
 * Write a program in C# Sharp to find the sum of all elements of the array
 */
            #region Q19
            int[] numbersQ19 = { 1, 2, 3, 4, 5, 6, 9, 8, 7 };
            int sum = 0;
            foreach (int j in numbersQ19)
            {
                sum += j;
            }
            Console.WriteLine($"The sume of the arrey = {sum}");
            #endregion

            /*
 * Write a program in C# Sharp to count a total number of duplicate elements in an array.
 */
            #region Q20
            int[] numbersQ20 = { 1, 2, 5, 9, 8, 6, 5, 4, 3, 2, 7, 8 };
            int dublicate = 0;
            for (int j = 0; j < numbersQ20.Length; j++)
            {
                int d = 0;
                foreach (int item in numbersQ20)
                {
                    if (item == numbersQ20[j])
                    {
                        d++;
                    }
                }
                if (d > 1)
                {
                    dublicate++;
                }
            }

            #endregion


            /*
             * Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
             */
            #region Q21

            int[] ls1 = { 1, 2, 3, 4, 5, 6 };
            int[] ls2 = { 7, 8, 9, 10, 11, 12 };
            ls1 = ls1.Concat(ls2).ToArray();
            Array.Sort(ls1);
            foreach (int j in ls1)
            {
                Console.Write(j + " ");
            }
            #endregion








        }
    }
}
