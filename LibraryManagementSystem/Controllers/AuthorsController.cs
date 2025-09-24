using LibraryManagementSystem.Data;
using LibraryManagementSystem.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LibraryManagementSystem.Controllers;

public class AuthorsController(LibraryContext context) : Controller
{
    public IActionResult Authors()
    {
        // DO NOT MODIFY ABOVE THIS LINE
        var authors = context.Authors
            .Include(a => a.Books)
            .ToList();
        return View(authors);
        // DO NOT MODIFY BELOW THIS LINE
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Author author)
    {
        // DO NOT MODIFY ABOVE THIS LINE
        if (ModelState.IsValid)
        {
            context.Authors.Add(author);
            context.SaveChanges();
            return RedirectToAction("Authors");
        }
        return View(author);
        // DO NOT MODIFY BELOW THIS LINE
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        // DO NOT MODIFY ABOVE THIS LINE
        
        var author = context.Authors.Find(id);
        if (author != null)
        {
            context.Authors.Remove(author);
            context.SaveChanges();
            return RedirectToAction("Authors");
        }
    
        return NotFound();
        // DO NOT MODIFY BELOW THIS LINE
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        // DO NOT MODIFY ABOVE THIS LINE
        
        var author = context.Authors.Find(id);
        if (author == null)
        {
            return NotFound();
        }
        return View(author);
        
        // DO NOT MODIFY BELOW THIS LINE
    }

    [HttpPost]
    public IActionResult Update(Author author)
    {
        // DO NOT MODIFY ABOVE THIS LINE
        if(ModelState.IsValid)
        {
            context.Authors.Update(author);
            context.SaveChanges();
            return RedirectToAction("Authors");
        }
        return View(author); // have to check if this is needed or not
        
        // DO NOT MODIFY BELOW THIS LINE
    }
}