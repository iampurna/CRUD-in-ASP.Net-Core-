using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
	public class Category
	{
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Enter number between 1 and 100")]
        public int DisplayOrder { get; set; }
    }
}

