using HtmlToPdfGenerator;
using DinkToPdf;
using DinkToPdf.Contracts;
namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HTML content to convert to PDF
            string htmlContent = "<html><body><h1>Hello, World!</h1></body></html>";

            // File path to save the PDF
            string pdfFilePath = "C:\\Users\\Amisha Gupta\\Desktop\\Test\\test.pdf";

            // Create a PDF converter
            var converter = new BasicConverter(new PdfTools());

            // Create an instance of HtmlToPdfConverter
            var htmlToPdfConverter = new HtmlToPdf(converter);

            // Convert HTML content to PDF and save to file
            htmlToPdfConverter.ConvertHtmlToPdf(htmlContent,true);

            Console.WriteLine("PDF generated successfully.");
        }
    }
}

