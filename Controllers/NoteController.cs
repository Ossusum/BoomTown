using BoomTown.Butler;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoomTown.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController : ControllerBase
    {
        NoteButler noteButler;
        public NoteController()
        {
            noteButler = new NoteButler();
        }

        [HttpGet]
        public List<Note> GetListOfNotes()
        {
            return noteButler.GetAListOfNotes();
        }

        [HttpPost]
        [Route("AddNote")]
        public void AddNote(Note note)
        {
            noteButler.AddNote(note);
        }

        [HttpGet]
        [Route("{id}")]
        public Note GetNote(int id)
        {
            return noteButler.GetNote(id);
        }

        [HttpPost]
        [Route("EditNote")]
        public void EditNote(Note note)
        {
            noteButler.EditNote(note);
        }

        [HttpGet]
        [Route("DeleteNote/{id}")]
        public Note DeleteNote(int id)
        {
            return noteButler.DeleteNote(id);
        }
    }
}
