

using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class FirstPageModel : PageModel
{
    //OnGet,OnGetAbc,OnGetXyz,...
    //OnPost(),OnPostAbc,...
    // ==> handler

    public void OnGet()
    {
        Console.WriteLine("Truy van get");
        ViewData["mydata"] = "Tran Dinh Khanh 20MC";

    }

    public void OnGetXyz()
    {
        Console.WriteLine("Truy van get");
        ViewData["mydata"] = "Tran Dinh Khanh 20MC Xyz";

    }

    public string title { set; get; } = "Day la trang Razor cua Tran Dinh Khanh";

    public string welcome(string name)
    {
        return $"Chao mung {name} den voi website";
    }
}