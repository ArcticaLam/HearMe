namespace HearMe.DataAccess.Entities.Mapping
{
    internal class UserMapping : BaseMapping<int,User>
    {
        public UserMapping()
        {
            Property(x => x.Id).HasColumnName("UserId");
        }
    }
}
