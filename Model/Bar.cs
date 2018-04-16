﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Guitab.Model.Glyphs;

namespace Guitab.Model
{
    class Bar
    {
        internal readonly int barNumber;
        readonly State state;
        internal List<Chord> chords = new List<Chord>();
        internal List<Note> notes = new List<Note>();

        internal int beatsPerBar { get { return state.beatsPerBar; } }

        internal Bar(int barNumber, State state)
        {
            this.barNumber = barNumber;
            this.state = state;
        }

        internal void Add(Chord chord)
        {
            chords.Add(chord);
        }

        internal void Add(Note note)
        {
            notes.Add(note);
        }

        void assert(Glyph glyph)
        {
            if (glyph.time >= beatsPerBar)
                throw new Exception();
        }
    }
}
