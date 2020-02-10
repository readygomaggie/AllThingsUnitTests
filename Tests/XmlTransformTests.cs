using System;
using System.Xml.Linq;
using Xunit;


namespace XMLTransformTests
{
    public class XmlTransformShould
    {
        XDocument originalXml = new XDocument(
            new XElement("Risk",
                new XElement("EndorsementName", "EndorsementName"),
                new XElement("EndorsementNumber", "E123456"))
            );
        

        [Fact]
        public void ReturnXmlUnChanged()
        {
            var expected = new XDocument(XDocument.Parse(@"
            <Risk>
                <EndorsementName>EndorsementName</EndorsementName>
                <EndorsementNumber>E123456</EndorsementNumber>
            </Risk>"));

            Assert.Equal(expected.ToString(), originalXml.ToString());
            //Assert.Equal(expected, originalXml);
            // Assert.Equal(expected.ToString(), transformedXML.ToString());
            
        }

        // [Fact]
        public void ReturnEndorsementElementsUnderEndorsementNode()
        {
            var expected = new XElement(XElement.Parse(@"
            <Risk>
                <Endorsement>
                    <EndorsementName>EndorsementName</EndorsementName>
                    <EndorsementNumber>E123456</EndorsementNumber>
                </Endorsement>
            </Risk>"));
            
            // var transformedXML = transformer.TransformXml(originalXml);         

            // Assert.Equal(expected.ToString(), transformedXML.ToString());
        }
    }
}