namespace HearMe.DataAccess.Entities
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
