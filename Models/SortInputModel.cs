using System.ComponentModel.DataAnnotations;

namespace NumberSortApp.Models
{
    public class SortInputModel
    {
        [Required(ErrorMessage = "Please enter numbers separated by commas.")]
        public string Numbers { get; set; }

        [Required(ErrorMessage = "Please select the sorting direction.")]
        public string SortingDirection { get; set; }
    }
}
