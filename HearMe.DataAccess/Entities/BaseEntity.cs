using System;

namespace HearMe.DataAccess.Entities
{
    public abstract class BaseEntity<TId>
    {
        public TId Id { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdateOn { get; set; }
        public bool IsDeactive { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
