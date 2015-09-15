using System.Web;
using PT.Framework.ViewModelResolver.Presentation;

namespace Accordion.Presentation.ViewModels
{
  public class AccordionViewModel : MappedViewModel<AccordionViewModel>
  {
    public HtmlString Title { get { return RenderField(m => m.Title); } }
    public HtmlString Text { get { return RenderField(m => m.Text); } }
  }
}