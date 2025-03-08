using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace todolist.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public DbSet<todolist.models.Task> Tasks;   // ここでDBから取得したデータを保持すして、Viewに渡す
    public void OnGet()
    {
        Db db = new();      // ここでDBに接続
        Tasks = db.Tasks;   // ここでDBからデータを取得
    }
}
