﻿using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace zKitap2Pdf
{
    internal class PDFUtil
    {
        public static void ConvertImagesToPdf(string[] imagePaths, string outputFileName)
        {
            using (var pdfWriter = new PdfWriter(outputFileName))
            {
                using (var pdfDocument = new PdfDocument(pdfWriter))
                {
                    var document = new Document(pdfDocument, PageSize.A4);

                    foreach (var imagePath in imagePaths)
                    {
                        var imageData = ImageDataFactory.Create(imagePath);
                        var image = new iText.Layout.Element.Image(imageData);
                        document.Add(image);
                    }

                    document.Close();
                }
            }
        }
    }
}