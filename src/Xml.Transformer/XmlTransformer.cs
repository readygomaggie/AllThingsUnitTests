using System;
using System.Xml.Linq;

namespace Xml.Transformer
{
    public class XmlTransformer
    {
        public XmlTransformer()
        {
        }

        public XDocument TransformXml(XDocument xml)
        {
            var allElements = xml.Element("Risk").Elements();
            foreach (var element in allElements)
            {
                Console.WriteLine(element);
            }

            var riskElement = xml.Element("Risk");
            var endorsmentElements = riskElement.Elements();

                        foreach (var element in endorsmentElements)
            {
                Console.WriteLine(element);
            }

            var tranformedXML = new XDocument(
                                    new XElement("Risk",
                                        new XElement("Endorsement",
                                            new XElement("New")
                                                    )
                                                )
                                            );
                                
            Console.WriteLine(tranformedXML);

            return xml;
        }
    }
}