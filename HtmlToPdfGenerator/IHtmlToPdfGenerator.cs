

namespace HtmlToPdfGenerator{
    
        public interface IHtmlToPdfGenerator
        {
            /// <summary>
            /// Converts HTML content to a PDF file with pagination.
            /// </summary>
            /// <param name="htmlContent">The HTML content to convert.</param>
            /// <param name="includePagination">Indicates whether to include pagination in the PDF.</param>
            /// <returns>A byte array representing the generated PDF file.</returns>
            byte[] ConvertHtmlToPdf(string htmlContent,bool includePagination,string documentTitle);
        }
    
}
