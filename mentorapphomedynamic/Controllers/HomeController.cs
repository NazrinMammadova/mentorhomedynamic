using mentorapphomedynamic.DAL;
using mentorapphomedynamic.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mentorapphomedynamic.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.Hero = _context.Heroes.FirstOrDefault();
            homeVM.About = _context.Abouts.FirstOrDefault();
            homeVM.WhyUss=_context.WhyUss.ToList();
            homeVM.Features = _context.Features.ToList();
            homeVM.Trainers = _context.Trainers.Include(t => t.SocialMedias).ToList();
            homeVM.PopularCourses=_context.PopularCourse.Include(p=>p.Trainer).ToList();
        
            return View(homeVM);
        }
    }
}
