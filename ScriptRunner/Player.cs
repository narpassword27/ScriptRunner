using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptRunner
{
    public class Player
    {
        //Just populated these based on what I think it'd need.
        //  some basic implementation hooked up to these, feel free to change if needed.
        public enum Color { Red, Green, Blue, Yellow, White};
        public int Speed;
        public Color CurrentColor;

        //single car only, don't know what to do for async psync yet
        public int SegmentPosition;
    }
}
