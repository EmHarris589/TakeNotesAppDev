using System.Collections.Generic;

namespace TakeNotes.Models
{
    public class Note 
    {
        

        public int ID { get; set; }
        public string NoteName { get; set; }

        public string Highlight { get; set; }
        
        public string noteText { get; set; }
        
        public int NoteColor { get; set; }

        public string currentColor
        {
            get
            {
                if (NoteColor == 1) return "#b1eb2f";
                if (NoteColor == 2) return "#9fda22";
                if (NoteColor == 3) return "#f5f128";
                if (NoteColor == 4) return "#5ce2de";
                if (NoteColor == 5) return "#febab5";
                return "#ffffff";
            }
        }

        public string Label { get; set; }

        public Note(int iD, string notename, string highlight, string noteText, int noteColor, string label)
        {
            ID = iD;
            NoteName = notename;
            Highlight = highlight;
            this.noteText = noteText;
            NoteColor = noteColor;
            Label = label;
        }

        public static List<Note> GetNotes() => new List<Note>
        {
            new Note(001, "Trip to the Zoo", "date with Chad", "Don't forget to pack the cooler with drinks", 3, "dates"),
            new Note(010, "To Do", "IMPORTANT", "Pick up boomer from the vet at 3pm", 1, "IMPORTANT"),
            new Note(104, "Groceries", "dinner out on Wednesday", "Milk, eggs, bread, lunch meat, cat food", 5, "Grocery"),
            new Note(215, "Ideas", "Be a boss bish", "Go over presentation for Tuesday, make sure all slides are perfect!", 4, "Ideas"),
            new Note(220, "Reminder", "Get change for turnpike", "Mom flies in on wednesday, pick up at airport 3pm, Gate 2B", 2, "Reminder")

        };
    }
}
