namespace WebAPI.Models
{
    public class ChildPostModel
    {
        public string Identity { get; set; } = null!;

        public string ParentId { get; set; } = null!;

        public DateTime BornDate { get; set; }

        public string Name { get; set; } = null!;
    }
}
