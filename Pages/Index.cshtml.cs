using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace dotnetdemo.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        var test11 = JsonConvert.SerializeObject(new { Name = "John", Age = 30 });
        _logger.LogInformation(test11);
    }

    public void OnGet()
    {

    }
}
