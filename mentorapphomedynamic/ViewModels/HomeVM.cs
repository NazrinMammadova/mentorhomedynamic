using mentorapphomedynamic.Models;

namespace mentorapphomedynamic.ViewModels
{
    public class HomeVM
    {
        public Hero Hero { get; set; }
        public About About { get; set; }
        public List<WhyUs> WhyUss {  get; set; }
        public List<Feature> Features { get; set; }
        public List<Trainer> Trainers { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
        public List <PopularCourse> PopularCourses { get; set; }
        
    }
}
