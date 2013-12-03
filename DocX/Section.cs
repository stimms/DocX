using System.Xml.Linq;
using System.Collections.Generic;

namespace Novacode
{
  public class Section : Container
  {

    public SectionBreakType SectionBreakType;

    internal Section(DocX document, XElement xml) : base(document, xml)
    {
    }

    public List<Paragraph> SectionParagraphs { get; set; }
  }
}