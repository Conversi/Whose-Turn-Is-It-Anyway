using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Whose_Turn_Is_It_Anyway.Models
{
 
    public class JobViewModel
    {
        [Required]
        [Display(Name = "Shared Task Name")]
        public string TaskName { get; set; }

        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 0)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Add Helpers")]
        public string AddHelper { get; set; }
    }

}