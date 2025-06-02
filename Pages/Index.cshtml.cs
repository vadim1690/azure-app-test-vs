using Microsoft.AspNetCore.Mvc.RazorPages;

namespace azure_app_trev.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IConfiguration _configuration;

    public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public void OnGet()
    {
        ViewData["Greetings"] = _configuration["Greetings"] ?? "Hello, World!";
    }
}
