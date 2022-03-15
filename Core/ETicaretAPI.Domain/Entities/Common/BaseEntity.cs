namespace ETicaretAPI.Domain.Entities.Common
{
    public  class BaseEntity
    {
        public Guid ID { get; set; }
        public DateTime  CreatedData { get; set; }
    }
}
