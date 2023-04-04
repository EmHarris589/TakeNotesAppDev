using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakeNotes.Models;

namespace TakeNotes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController : ControllerBase
    {
        private static readonly List<Note> _notes = Note.GetNotes();
       
        private readonly ILogger<NoteController> _logger;

        public NoteController(ILogger<NoteController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Note> Get() => Note.GetNotes();
        
    }
}
