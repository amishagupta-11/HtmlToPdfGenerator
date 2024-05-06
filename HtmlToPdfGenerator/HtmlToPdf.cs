using DinkToPdf;
using DinkToPdf.Contracts;
using HtmlToPdfGenerator;


public class HtmlToPdf : IHtmlToPdfGenerator
{
    private readonly IConverter _converter;

    public HtmlToPdf(IConverter converter)
    {
        _converter = converter;
    }
    /// <summary>
    /// method that converts html content into pdf format
    /// </summary>
    /// <param name="htmlContent"></param>
    /// <param name="paginationEnabled"></param>
    /// <param name="documentTitle"></param>
    /// <returns></returns>

    public byte[] ConvertHtmlToPdf(string htmlContent, bool paginationEnabled = true, string? documentTitle = null)
    {
        htmlContent= $"<h1>{documentTitle}</h1>{htmlContent}";        

        var doc = new HtmlToPdfDocument()
        {
            GlobalSettings =
            {
                PaperSize = PaperKind.A4,
                Orientation = Orientation.Portrait                
            }        
            
        };
        var objectSettings = new ObjectSettings
        {
            HtmlContent = htmlContent,

            WebSettings = new WebSettings
            {
                DefaultEncoding = "utf-8"
            },

            // Configure header settings

            HeaderSettings = new HeaderSettings
            {
                FontName = "Calibri",
                FontSize = 9,
                Line = true,
                Center = "Cognine"
            },

            // Configure footer settings
            FooterSettings = new FooterSettings
            {
                FontName = "Calibri",
                FontSize = 9,
                Line = true,
                Center = "Page [page] of [toPage]"
            }

        };
        // Add the object settings to the document
        doc.Objects.Add(objectSettings);
        var pdfBytes = _converter.Convert(doc);
        return pdfBytes;

        
    }  
   
    
}
