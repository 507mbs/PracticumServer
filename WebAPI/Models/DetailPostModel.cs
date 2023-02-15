namespace WebAPI.Models
{
    public class DetailPostModel
    {
        public string Idenentity { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public DateTime BornDate { get; set; }

        public string Gender { get; set; } = null!;

        public string Hmo { get; set; } = null!;
    }
}
