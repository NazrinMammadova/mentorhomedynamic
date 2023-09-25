namespace mentorapphomedynamic.Models
{
    public class SocialMedia
    {
        public int Id { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }
        public Trainer Trainer { get; set; }
        public int TrainerId { get; set; }
    }
}
