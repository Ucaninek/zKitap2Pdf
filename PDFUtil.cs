using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;

namespace zKitap2Pdf
{
    internal class PDFUtil
    {
        public static async Task ConvertImagesToPdf(string[] imagePaths, string outputFileName, PageSize pageSize)
        {
            using (var pdfWriter = new PdfWriter(outputFileName))
            {
                using (var pdfDocument = new PdfDocument(pdfWriter))
                {
                    var document = new Document(pdfDocument, pageSize);
                    document.SetMargins(0f, 0f, 0f, 0f);

                    foreach (var imagePath in imagePaths)
                    {
                        var imageData = await Task.Run(() => ImageDataFactory.Create(imagePath));
                        var image = new iText.Layout.Element.Image(imageData);
                        document.Add(image);
                    }

                    document.Close();
                }
            }
        }
    }
}
