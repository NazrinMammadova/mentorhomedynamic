namespace mentorapphomedynamic.Models
{
    public class PopularCourse
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }


    }
}
