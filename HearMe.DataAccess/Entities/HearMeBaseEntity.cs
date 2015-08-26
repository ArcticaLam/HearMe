namespace HearMe.DataAccess.Entities
{
    public abstract class HearMeBaseEntity : BaseEntity<int>
    {
        public bool IsDeactive { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
