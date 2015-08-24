using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HearMe.DataAccess.Entities.Mapping
{
    internal class BaseMapping<T>:EntityTypeConfiguration<T> where T:BaseEntity
    {
        internal BaseMapping()
        {
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
