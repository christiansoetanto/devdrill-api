using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevDrillAPI.Entities
{
    public class CobaCoba
    {
        public int Key { get; set; }
        public string Test { get; set; }
    }

    public class CobaCobaModelBuilder : IEntityTypeConfiguration<CobaCoba>
    {
        public void Configure(EntityTypeBuilder<CobaCoba> entity)
        {
            entity.HasKey(e => e.Key);
        }
    }
}