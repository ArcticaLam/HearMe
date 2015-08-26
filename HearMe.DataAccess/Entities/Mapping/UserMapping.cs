namespace HearMe.DataAccess.Entities.Mapping
{
    internal class UserMapping : HearMeBaseMapping<User>
    {
        public UserMapping()
        {
            Property(x => x.Id).HasColumnName("UserId");
        }
    }
}
