using Microsoft.AspNetCore.Mvc;
using NumberSortApp.Data;
using NumberSortApp.Models;

namespace NumberSortApp.Controllers
{
    public class SortController : Controller
    {
        private readonly AppDbContext _context;

        public SortController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Sort()
        {
            var model = new SortInputModel();
            return View(model);
        }


        // Action to handle sorting of numbers
        [HttpPost]
        public IActionResult Sort(SortInputModel inputModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (!inputModel.Numbers.Contains(','))
                    {
                        ModelState.AddModelError("Numbers", "Please enter numbers separated by commas.");
                        return View(inputModel);
                    }

                    int[] numbers = inputModel.Numbers.Split(',').Select(int.Parse).ToArray();

                    // Perform sorting based on direction
                    int[] sortedNumbers = inputModel.SortingDirection == "asc"
                                            ? numbers.OrderBy(n => n).ToArray()
                                            : numbers.OrderByDescending(n => n).ToArray();

                    // Save sorted sequence to the database
                    var sortNumber = new SortNumber
                    {
                        SortedNumbers = sortedNumbers,
                        SortingDirection = inputModel.SortingDirection,
                        SortingTime = DateTime.Now.TimeOfDay
                    };

                    _context.Add(sortNumber);
                    _context.SaveChanges();

                    // Redirect to action to display sorted sequences
                    return RedirectToAction(nameof(DisplaySortedSequences));
                }

                // If model state is not valid, return to sorting view with errors
                return View(inputModel);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                // For simplicity, just returning an error view
                ViewData["ErrorMessage"] = "An error occurred while sorting: " + ex.Message;
                return View(inputModel);
            }
        }

        // Action to display sorted sequences
        public IActionResult DisplaySortedSequences()
        {
            var sortedSequences = _context.SortModels.ToList();
            return View(sortedSequences);
        }

        // Action to export sorted sequences as JSON
        public IActionResult ExportSortedSequences()
        {
            var sortedSequences = _context.SortModels.ToList();
            return Json(sortedSequences);
        }

     
    }

}
