using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feature.Navigation.Models
{
    [SitecoreType(TemplateId = "{95C3FCBC-1FC7-4CDA-B50B-FB7775AF032F}")]
    public class HomeItem : MenuItem
    {
        [SitecoreChildren]
        public virtual IEnumerable<MenuItem> MenuItems { get; set; }
    }
}