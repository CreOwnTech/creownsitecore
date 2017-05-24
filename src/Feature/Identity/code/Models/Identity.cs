using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Foundation.GlassMapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feature.Identity.Models
{
    public class Identity : SitecoreItem
    {
        [SitecoreField("Logo")]
        public virtual Image Logo { get; set; }

        [SitecoreField("OrganisationPhone")]
        public virtual string OrganisationPhone { get; set; }

        [SitecoreField("OrganisationEmail")]
        public virtual Link OrganisationEmail { get; set; }
    }
}