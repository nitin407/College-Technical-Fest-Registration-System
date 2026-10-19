using Microsoft.AspNetCore.Mvc;

namespace CollegeFestMVC.Controllers;

public class FestController : Controller
{
    private static readonly List<Participant> participants = new();
    private static int nextId = 1;

    private readonly Dictionary<string, decimal> fees = new()
    {
        ["Coding Challenge"] = 0,
        ["Web Design"] = 200,
        ["Hackathon"] = 500,
        ["Gaming"] = 300
    };

    public IActionResult Index()
    {
        return View(participants);
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View(new Participant());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Register(Participant participant)
    {
        if (!ModelState.IsValid)
            return View(participant);

        participant.ParticipantId = nextId++;
        participant.RegistrationFee = fees.ContainsKey(participant.EventName)
            ? fees[participant.EventName]
            : 0;
        participant.IsCompleted = true;
        participants.Add(participant);

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Details(int id)
    {
        var participant = participants.FirstOrDefault(p => p.ParticipantId == id);
        if (participant == null)
            return NotFound();

        return View(participant);
    }

    public IActionResult Welcome()
    {
        return View();
    }
}
