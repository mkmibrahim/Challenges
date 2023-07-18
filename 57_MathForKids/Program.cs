using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Net.Http.Headers;

namespace _57_MathForKids
{
    internal class Program
    {
        

        public static void Main(String[] args)
        {
            MathExercisePdfGenerator generator = new MathExercisePdfGenerator();
            generator.GenerateMathExercisePdf("math_exercises.pdf");
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
                document.Add(new Paragraph("Makkelijk!"));
                Table table = CreateExcercieTable(30);
                document.Add(table);

                document.Add(new Paragraph("Een beetje moeilijker!"));
                table = CreateExcercieTable(50);
                document.Add(table);

                document.Add(new Paragraph("Nog moeilijker 1!"));
                table = CreateExcercieTable(50);
                document.Add(table);

                document.Add(new Paragraph("Nog moeilijker 2!"));
                table = CreateExcercieTable(100);
                document.Add(table);

                document.Add(new Paragraph("Nog moeilijker3 !"));
                table = CreateExcercieTable(200);
                document.Add(table);
            }
        }

        private Table CreateExcercieTable(int maxInt)
        {
            // Create a table with two columns
            Table table = new Table(2);
            table.UseAllAvailableWidth();

            for (int i = 1; i <= 138; i++)
            {
                // Generate the math exercise content
                string exercise = GenerateMathExercise(maxInt);

                // Create a cell for the exercise and add it to the table
                Cell cell = new Cell();
                cell.Add(new Paragraph(exercise));
                table.AddCell(cell);
            }

            return table;
        }

        private string GenerateMathExercise(int maxInt)
        {
            Random random = new Random();

            char[] operators =  { '+', '-'};
            char selectedOperator = operators[random.Next(operators.Length)];

            int number1 = random.Next(1, maxInt);
            int number2 = selectedOperator == '-' ? random.Next(0,number1) : random.Next(1, maxInt);

            string number1String = number1 < 10 ? (number1 + "  ") : number1.ToString();
            string number2String = number2 < 10 ? (number2 + "  ") : number2.ToString();

            return $"{number1String} {selectedOperator} {number2String} = _______";
        }
    }



    
}