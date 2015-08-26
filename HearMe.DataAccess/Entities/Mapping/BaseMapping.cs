using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HearMe.DataAccess.Entities.Mapping
{
    internal class BaseMapping<TId, TEntity> : EntityTypeConfiguration<TEntity> where TEntity : BaseEntity<TId> where TId : struct
    {
        public BaseMapping()
        {
            Property(x => x.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
