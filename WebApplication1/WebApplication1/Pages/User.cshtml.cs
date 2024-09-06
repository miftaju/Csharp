using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class UserModel : PageModel
    {
        private readonly MyDbContext _context;
        public List<User> Users { get; set; }=new List<User>();
        [BindProperty]
        public User NewUser { get; set; }

        public UserModel(MyDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Users= _context.Users.ToList();
        }
        public IActionResult OnPost()
        {
            _context.Users.Add(NewUser);
            _context.SaveChanges();
            return RedirectToPage();
        }
    }
}
