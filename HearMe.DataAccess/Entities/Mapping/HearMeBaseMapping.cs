namespace HearMe.DataAccess.Entities.Mapping
{
    internal class HearMeBaseMapping<TEntity> : BaseMapping<int, TEntity> where TEntity : HearMeBaseEntity
    {
        public HearMeBaseMapping()
        {
            Property(x => x.RowVersion).IsRowVersion();
        }
    }
}
