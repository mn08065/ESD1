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
        // TODO: 11.1 Fetch all authors and return list, include Books for each author and return the view with authors
        // Refer to similar listing for Members
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
        // TODO: 11.4 Check if author exists, remove author from context and save changes, then redirect to Authors action
        var author = context.Authors.Find(id);
        if (author != null)
        {
            context.Authors.Remove(author);
            context.SaveChanges();
            return RedirectToAction("Authors");
        }
        // TODO: 11.5 Return NotFound() if author does not exist
            throw new NotImplementedException("AuthorsController.Delete is not implemented");
        // DO NOT MODIFY BELOW THIS LINE
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        // DO NOT MODIFY ABOVE THIS LINE
        // TODO: 11.6 Find author by id, return NotFound() if author does not exist, otherwise return the view with author
        throw new NotImplementedException("AuthorsController.Update is not implemented");
        // DO NOT MODIFY BELOW THIS LINE
    }

    [HttpPost]
    public IActionResult Update(Author author)
    {
        // DO NOT MODIFY ABOVE THIS LINE
        // TODO: 11.7 Check if model is valid then update author in context and save changes, then redirect to Authors action
        throw new NotImplementedException("AuthorsController.Update is not implemented");
        // DO NOT MODIFY BELOW THIS LINE
    }
}