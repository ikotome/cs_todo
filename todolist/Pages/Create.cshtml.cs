using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace todolist.Pages
{
    public class CreateModel : PageModel
    {
        public void OnGet()
        {

        }

        public IActionResult OnPost(string title, string description, DateTime limitdate, string status)
        {
            Db db =new();
            models.Task.Taskstatus change = models.Task.Taskstatus.Todo;
            if (status == "done")   change = models.Task.Taskstatus.Done;
            else if(status == "doing")  change = models.Task.Taskstatus.Doing;
            
            db.Tasks.Add(new todolist.models.Task { Title = title, Description = description, Limitdate = limitdate, Status = change });
            db.SaveChanges();
            return Redirect("/");
        }
    }
}
