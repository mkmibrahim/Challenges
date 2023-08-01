using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Net.Http.Headers;
using static iText.Signatures.LtvVerification;

namespace _57_MathForKids
{
    internal class Program
    {
        

        public static void Main(String[] args)
        {
            MathExercisePdfGenerator generator = new MathExercisePdfGenerator();
            generator.GenerateMathExercisePdf("math_exercises.pdf");
            Console.WriteLine("File is generated in " + System.IO.Path.GetFullPath("math_exercises.pdf"));
        }
    }
    
    

    public class MathExercisePdfGenerator
    {
        public void GenerateMathExercisePdf(string filePath)
        {
            using (PdfWriter writer = new PdfWriter(filePath))
            using (PdfDocument pdf = new PdfDocument(writer))
            using (Document document = new Document(pdf))
            {
                document.SetMargins(20, 20, 20, 20);

                // Calculate the number of rows per column
                int rowsPerColumn = (int)Math.Ceiling((double)100 / 2);
            
                document.Add(new Paragraph("Makkelijk 1"));
                Table table = CreateExcercieTable(30, Level.Easy);
                document.Add(table);

                document.Add(new Paragraph("Makkelijk 2"));
                table = CreateExcercieTable(30, Level.Easy);
                document.Add(table);

                document.Add(new Paragraph("Makkelijk 3"));
                table = CreateExcercieTable(30, Level.Easy);
                document.Add(table);

                document.Add(new Paragraph("Een beetje moeilijker 1"));
                table = CreateExcercieTable(50, Level.Easy);
                document.Add(table);

                document.Add(new Paragraph("Een beetje moeilijker 2"));
                table = CreateExcercieTable(50, Level.Easy);
                document.Add(table);
                document.Add(new Paragraph("Een beetje moeilijker 3"));
                table = CreateExcercieTable(50, Level.Easy);
                document.Add(table);
            }
        }

        private enum Level { Easy, Medium, Hard }

        private Table CreateExcercieTable(int maxInt, Level requestedLevel)
        {

            // Create a table with two columns
            Table table = new Table(2);
            table.UseAllAvailableWidth();

            for (int i = 1; i <= 138; i++)
            {
                // Generate the math exercise content
                string exercise = GenerateMathExercise(maxInt, requestedLevel);

                // Create a cell for the exercise and add it to the table
                Cell cell = new Cell();
                cell.Add(new Paragraph(exercise));
                table.AddCell(cell);
            }

            return table;
        }

        private string GenerateMathExercise(int maxInt, Level requestedLEvel)
        {
            Random random = new Random();

            char[] operators =  { '+', '-', '*', '/'};
            char selectedOperator = operators[random.Next(operators.Length)];

            int number1 = random.Next(1, maxInt);
            int number2 = selectedOperator == '-' ? random.Next(0,number1) : random.Next(1, maxInt);
            if (selectedOperator == '+')
            {
                number1 = random.Next(1, maxInt);
                number2 = random.Next(1, maxInt);
            }
            else if (selectedOperator == '-')
            {
                number2 = selectedOperator == '-' ? random.Next(0,number1) : random.Next(1, maxInt);
            }
            else if (selectedOperator == '*')
            {
                if (requestedLEvel == Level.Easy)
                {
                    number1 = random.Next(1, 10);
                    number2 = random.Next(1, 10);
                }
                else if (requestedLEvel == Level.Medium)
                {
                    number1 = random.Next(1, 20);
                    number2 = random.Next(1, 20);
                }
                else if (requestedLEvel == Level.Hard)
                {
                    number1 = random.Next(1, 50);
                    number2 = random.Next(1, 50);
                }
                number1 = random.Next(1, 10);
            }
            else if (selectedOperator == '/')
            {
                if (requestedLEvel == Level.Easy)
                {
                    number1 = random.Next(1, 6);
                    number2 = random.Next(1, 6);
                    number1 *= number2;
                }
                else if (requestedLEvel == Level.Medium)
                {
                    number1 = random.Next(1, 10);
                    number2 = random.Next(1, 10);
                    number1 *= number2;
                }
                else if (requestedLEvel == Level.Hard)
                {
                    number1 = random.Next(1, 20);
                    number2 = random.Next(1, 20);
                    number1 *= number2;
                }
            }
            string number1String = number1 < 10 ? (number1 + "  ") : number1.ToString();
            string number2String = number2 < 10 ? (number2 + "  ") : number2.ToString();
            string operatorString = getOperatorString(selectedOperator);
            return $"{number1String} {operatorString} {number2String} = ";
        }

        private string getOperatorString(char selectedOperator)
        {
            if (selectedOperator == '+')
            {
                return "+";
            }
            else if (selectedOperator == '-')
            {
                return "-";
            }
            else if (selectedOperator == '*')
            {
                return "x";
            }
            else if (selectedOperator == '/')
            {
                return "÷";
            }
            else
                return "";
        }
    }



    
}