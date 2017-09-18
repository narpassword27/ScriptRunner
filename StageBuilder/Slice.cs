using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScriptRunner;

namespace StageBuilder
{
    internal class Slice
    {
        private Segment[] _segments;

        //Can change this later
        private const int _startPosition = 15;

        public int renderPosition
        {
            get
            {
                //TODO
                return 0;
            }
            set
            {
                //TODO
            }
        }

        //Parse the hex string into segments
        public Slice(string hexInstruction)
        {
            renderPosition = _startPosition;
            _segments = hexInstruction.Select(c => new Segment(c)).ToArray();
        }

        //Calling this with a player object will do whatever logic is in the current segment
        public Action<Player> AtSegment => (P => _segments[P.SegmentPosition].OnCollision(P));
    }
}
