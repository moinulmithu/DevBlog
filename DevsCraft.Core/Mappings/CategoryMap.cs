using DevsCraft.Core.Objects;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsCraft.Core.Mappings
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Map(x => x.Id);
            Map(x => x.Name).Length(100).Not.Nullable();
            Map(x => x.UrlSlug).Length(50).Not.Nullable();
            Map(x => x.Description).Length(1000);
            HasMany(x => x.Posts).Inverse().Cascade.All().KeyColumn("Category");
        }
    }
}
