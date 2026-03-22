using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibSystem.Pages
{
    public class IndexModel : PageModel
    {
        public void OnPost(string studentID, string name, string action)
        {
            string filePath = "Logs.csv";

            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string time = DateTime.Now.ToString("hh:mm:ss tt");

            string record = "";

            if(action == "timein")
            {
                record = $"{studentID},{name},{date},{time},Time In";
            }
            else
            {
                record = $"{studentID},{name},{date},{time},Time Out";
            }

            System.IO.File.AppendAllText(filePath, record + "\n");
        }
    }
}
