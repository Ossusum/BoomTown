using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoomTown.Butler
{
    public class NoteButler
    {
        private string FilePath = @"..\notes.txt";
        private List<Note> AllNotes;

        public NoteButler()
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Close();
            }
            AllNotes = ReadFromJSON();
        }

        public void AddNote(Note note)
        {
            note.ID = AllNotes.Count;
            AllNotes.Add(note);
            WriteToJSON(AllNotes);
        }

        public List<Note> GetAListOfNotes()
        {
            return ReadFromJSON();
        }

        public Note GetNote(int id)
        {
            return AllNotes.Where(note => note.ID == id).FirstOrDefault();
        }

        public void EditNote(Note updatedNote)
        {

            AllNotes[AllNotes.FindIndex(note => note.ID == updatedNote.ID)] = updatedNote;
            WriteToJSON(AllNotes);
        }

        public Note DeleteNote(int id)
        {
            Note deletedNote = AllNotes.Where(x => x.ID == id).FirstOrDefault();
            AllNotes.RemoveAt(AllNotes.FindIndex(note => note.ID == id));
            WriteToJSON(AllNotes);
            return deletedNote;
        }


        #region Helper Functions

        private void WriteToJSON(List<Note> notes)
        {
            using (StreamWriter file = File.CreateText(FilePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, notes);
            }
        }

       
        private List<Note> ReadFromJSON()
        {
            List<Note> notes = JsonConvert.DeserializeObject<List<Note>>(File.ReadAllText(FilePath));
            if (notes == null)
            {
                notes = new List<Note>();
            }
            return notes;
        }

        #endregion
    }
}
