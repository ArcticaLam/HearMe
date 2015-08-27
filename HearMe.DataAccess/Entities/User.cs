namespace HearMe.DataAccess.Entities
{
    public class User : BaseEntity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
