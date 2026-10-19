using System.ComponentModel.DataAnnotations;

namespace CollegeFestMVC.Models;

public class Participant
{
    public int ParticipantId { get; set; }

    [Required(ErrorMessage = "Participant name is required")]
    public string ParticipantName { get; set; } = "";

    [Required, EmailAddress]
    public string Email { get; set; } = "";

    [Required]
    public string Department { get; set; } = "";

    [Required]
    public string Year { get; set; } = "";

    [Required]
    public string EventName { get; set; } = "";

    public bool IsTeamEvent { get; set; }

    public bool IsCompleted { get; set; } = true;

    public decimal? RegistrationFee { get; set; }
}
