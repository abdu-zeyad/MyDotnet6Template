namespace Template.Models
{
    public class BaseModel
    {
        public virtual int Id { get; set; }
        public virtual DateTime DateTime { get; set; } = DateTime.Now;
    }
}
