using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using InternetRadio.WorkingWithFiles;



namespace InternetRadio.Engine
{
    public class ColorHelper
    {
        private const string ColorFile = "files/Color.xml";

        public static void SaveColor(Int32 color)
        {
            var colorXML = new XDocument(new XElement("Color", color));
            WorkFromFiles.SaveDocument(colorXML, ColorFile);
        }

        public static Color LoadColor()
        {
            try
            {
                var xElement = WorkFromFiles.LoadDocument(ColorFile).Root;
                return Color.FromArgb(Convert.ToInt32(xElement.Value));
            }
            catch
            {
                var writ = new StreamWriter(ColorFile, true);
                writ.Dispose();
                var temp = new XDocument(new XElement("Color", "-4144960"));
                WorkFromFiles.SaveDocument(temp, ColorFile);
                return Color.FromArgb(-4144960);    
            }
        }

    }
}
