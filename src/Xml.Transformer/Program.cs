using System;
using System.Xml.Linq;

namespace Xml.Transformer
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument originalXml = new XDocument(
                new XElement("Risk",
                    new XElement("EndorsementName", "EndorsementName"),
                    new XElement("EndorsementNumber", "E123456"))
            );

            XmlTransformer transformer = new XmlTransformer();
            var transformedXml = transformer.TransformXml(originalXml);

//            Console.WriteLine(originalXml);
 //           Console.WriteLine(transformedXml);
        }
    }
}
