using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoleMatesWA.Models;

public class CommentModel
{
    [Key]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    [StringLength(1000, ErrorMessage = "{0} length can't be more than 1000 characters")]
    [Display(Name = "Comment")]
    public string? Comment { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    [StringLength(100, ErrorMessage = "{0} length can't be more than 100 characters")]
    [Display(Name = "User")]
    public string? User { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    [Display(Name = "Date")]
    public DateOnly Date { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    [Display(Name = "Time")]
    public TimeSpan Time { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    [Display(Name = "Event ID")]
    public Guid EventId { get; set; }

    [ForeignKey("EventId")]
    [Display(Name = "Event")]
    public EventModel? Event { get; set; }
}
