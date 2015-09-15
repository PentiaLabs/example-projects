using PT.Framework.ViewModelResolver.Presentation;
using Sitecore.Data;

namespace Accordion.Presentation.ViewModels.Maps
{
  public class AccordionConfiguration : MappedViewModelConfiguration<AccordionViewModel>
  {
    public AccordionConfiguration()
    {
      SetClassPropertyFieldId(p => p.Title, new ID("{7CC4A041-58DC-4BF4-84A5-27449EC2F5C7}"));
      SetClassPropertyFieldId(p => p.Text, new ID("{5E49BBE2-ECE3-4AD7-A6E5-BA780FE1B3B3}"));
    }
  }
}