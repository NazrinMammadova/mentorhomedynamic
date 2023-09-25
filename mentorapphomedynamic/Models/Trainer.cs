namespace mentorapphomedynamic.Models
{
    public class Trainer
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Proffesion { get; set; }
        public string About { get; set; }
        public string ImageUrl { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }


    }
}
