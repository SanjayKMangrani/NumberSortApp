using System.ComponentModel.DataAnnotations;

namespace NumberSortApp.Models
{
    public class SortNumber
    {
        [Key] public int[] SortedNumbers { get; set; }
        public string SortingDirection { get; set; }
        public TimeSpan SortingTime { get; set; }
    }
}
