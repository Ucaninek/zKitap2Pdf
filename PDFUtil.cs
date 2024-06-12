using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using HorizontalAlignment = iText.Layout.Properties.HorizontalAlignment;

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

                        // Calculate the image dimensions and position
                        float imageWidth = image.GetImageScaledWidth();
                        float imageHeight = image.GetImageScaledHeight();
                        float pageWidth = pageSize.GetWidth();
                        float pageHeight = pageSize.GetHeight();
                        float x = (pageWidth - imageWidth) / 2;
                        float y = (pageHeight - imageHeight) / 2;

                        // Set the image position and alignment
                        image.SetFixedPosition(x, y);
                        image.SetHorizontalAlignment(HorizontalAlignment.CENTER);

                        document.Add(image);

                        // Add a new page for the next image
                        document.Add(new AreaBreak());
                    }

                    document.Close();
                }
            }
        }
    }
}
