using Sitecore.Foundation.GlassMapper.Models;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feature.Navigation.Models
{
    public class MenuItem : SitecoreItem
    {
        [SitecoreField("NavigationTitle")]
        public virtual string NavigationTitle { get; set; }

        [SitecoreField("ShowInNavigation")]
        public virtual bool ShowInNavigation { get; set; }

        [SitecoreField("ShowChildren")]
        public virtual bool ShowChildren { get; set; }
    }
}