using System.ComponentModel.DataAnnotations;

namespace SoleMatesWA.Models;

public class EventModel
{
    [Key]
    [Required]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    [StringLength(100, ErrorMessage = "Title length can't be more than 100 characters")]
    [Display(Name = "Event Title")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    [StringLength(500, ErrorMessage = "Description length can't be more than 500 characters")]
    [Display(Name = "Event Description")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    [Display(Name = "Event Date")]
    public DateOnly Date { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    [StringLength(200, ErrorMessage = "Location length can't be more than 200 characters")]
    [Display(Name = "Event Location")]
    public string? Location { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    [StringLength(200, ErrorMessage = "Venue length can't be more than 200 characters")]
    [Display(Name = "Event Venue")]
    public string? Venue { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    [Display(Name = "Start Time")]
    public TimeSpan StartTime { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    [Display(Name = "End Time")]
    public TimeSpan EndTime { get; set; }

    // Navigation property for related comments
    public ICollection<CommentModel>? Comments { get; set; }
}
