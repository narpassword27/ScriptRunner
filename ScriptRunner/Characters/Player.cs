using ScriptRunner.Util;
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
        //  Changing the name here because Color is a class somewhere in .net
        
        private int slicesPerSecond;
        public int SlicesPerSecond { get { return slicesPerSecond; } }

        private FirewallColors currentColor;
        public FirewallColors CurrentColor { get { return currentColor; } }

        //single car only, don't know what to do for async psync yet
        public int SegmentPosition;

        public Player()
        {
            
        }
    }
}
