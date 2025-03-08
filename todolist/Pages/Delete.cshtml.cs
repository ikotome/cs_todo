using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace todolist.Pages
{
    public class DeleteModel : PageModel
    {
        public IActionResult OnGet(int id)
        {
            Db db = new();
            var query = from task in db.Tasks
                        where task.ID == id
                        select task;
            models.Task result = query.FirstOrDefault();
            db.Tasks.Remove(result);
            db.SaveChanges();
            return Redirect("/");
        }
    }
}
