namespace HearMe.DataAccess.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
