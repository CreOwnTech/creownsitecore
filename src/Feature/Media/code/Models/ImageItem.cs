using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Foundation.GlassMapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feature.Media.Models
{
    [SitecoreType(TemplateId = "{2877CE31-2742-458B-938D-070903B8A45B}", AutoMap = true)]
    public class ImageItem : SitecoreItem
    {
        [SitecoreField("Title")]
        public virtual string Title { get; set; }

        [SitecoreField("Description")]
        public virtual string Description { get; set; }

        [SitecoreField("Image")]
        public virtual Image Image { get; set; }
    }
}