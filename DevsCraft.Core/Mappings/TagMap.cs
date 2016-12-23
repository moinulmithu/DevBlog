using DevsCraft.Core.Objects;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsCraft.Core.Mappings
{
    public class TagMap : ClassMap<Tag>
    {
        public TagMap()
        {
            Map(x => x.Id);
            Map(x => x.Name).Length(50).Not.Nullable();
            Map(x => x.UrlSlag).Length(100).Not.Nullable();
            Map(x => x.Description).Length(200);
            HasManyToMany(x => x.Posts).Cascade.All().Inverse().Table("PostTagMap");
        }
    }
}
