using Sitecore.AspNetCore.SDK.LayoutService.Client.Response.Model.Fields;
using Sitecore.AspNetCore.SDK.RenderingEngine.Binding.Attributes;

namespace Sitecore.AspNetCore.Starter.Models;

public class TitleAndText : BaseModel
{
    [SitecoreComponentField]
    public TextField? Title { get; set; }

    [SitecoreComponentField]
    public RichTextField? Text { get; set; }
}
