using System;
using System.IO;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;


namespace _57_MathForKids
{
    internal class Program
    {
        //public const String DEST = "../../../results/chapter01/hello_world.pdf";

        // public static void Main(String[] args) {
        //     FileInfo file = new FileInfo(DEST);
        //     file.Directory.Create();
        //     new Program().CreatePdf(DEST);
        // }

        // public virtual void CreatePdf(String dest) {
        //     //Initialize PDF writer
        //     PdfWriter writer = new PdfWriter(dest);
        //     //Initialize PDF document
        //     PdfDocument pdf = new PdfDocument(writer);
        //     // Initialize document
        //     Document document = new Document(pdf);
        //     //Add paragraph to the document
        //     document.Add(new Paragraph("Hello World!"));
        //     //Close document
        //     document.Close();
        // }

        public static void Main(String[] args)
        {
            MathExerciseGenerator generator = new MathExerciseGenerator();
            generator.GeneratePDF("math_exercises.pdf", 100);
        }

    }
        public class MathExerciseGenerator
    {
        public void GeneratePDF(string filePath, int numExercises)
        {
            PdfWriter writer = new PdfWriter(filePath);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            // Set up the font for exercise text
            PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            iText.Layout.Style style = new iText.Layout.Style().SetFont(font).SetFontSize(14);

            // Generate exercises
            for (int i = 1; i <= numExercises; i++)
            {
                string exercise = GenerateExercise();
                Paragraph paragraph = new Paragraph(exercise).AddStyle(style);
                document.Add(paragraph);
            }

            document.Close();
        }

        private string GenerateExercise()
        {
            Random random = new Random();

            // Generate two random numbers between 1 and 10
            int number1 = random.Next(1, 99);
            int number2 = random.Next(1, 99);

            // Generate an operator (+ or -)
            char[] operators = { '+', '-' };
            char selectedOperator = operators[random.Next(operators.Length)];

            // Create the exercise string
            string number1String = number1 < 10 ? (number1+"  ") : number1.ToString();
            string number2String = number2 < 10 ? (number2+"  ") : number2.ToString();
            string exercise = $"{number1String} {selectedOperator} {number2String} = _______";

            return exercise;
        }
    }

    
}