using Microsoft.AspNetCore.Mvc;
using TodoManager.Models;
using TodoManager.Data;
using Microsoft.EntityFrameworkCore;

namespace TodoManager.Controllers;
public class TodoController : Controller {
    private readonly AppDbContext _context;

    public TodoController(AppDbContext context)
    {
        _context = context;
    }
    public IActionResult Create(){
        return View();
    }

    public async Task<IActionResult> Index()
    {
        var todos = await _context.Todos.ToListAsync();
        if (todos == null || !todos.Any())
        {
            return View(new List<Todo>());
        }
        return View(todos);
    }
}
