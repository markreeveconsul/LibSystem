using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibSystem.Pages
{
    public class LogsModel : PageModel
    {
        public List<string[]> Logs = new List<string[]>();
        public void OnGet()
        {
            string filePath = "Logs.csv";
            if (System.IO.File.Exists(filePath))
            {
                var lines = System.IO.File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var logEntry = line.Split(',');
                    Logs.Add(logEntry);
                }
            }
        }
    }
}
