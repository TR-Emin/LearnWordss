using LearnWordss.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnWordss.Controllers
{
    public class WordController : Controller
    {

        private readonly AppDbContext _appDbContext;
        Random random = new Random();


        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public Word Get()
        {
            int countWords = _appDbContext.Words.Count();
            int getId = random.Next(1, countWords);
            var word = _appDbContext.Words.Where(n => n.Id == getId).FirstOrDefault();
            return word;
                
        }
    }
}
