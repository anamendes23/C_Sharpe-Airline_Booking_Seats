using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Row
    {
        //fields
        private bool _leftSideWindowSeat;
        private bool _leftSideAisleSeat;
        private bool _rightSideWindowSeat;
        private bool _rightSideAisleSeat;
        //constructors
        public Row()
        {
            _leftSideWindowSeat = false; //'A'
            _leftSideAisleSeat = false; //'B'
            _rightSideWindowSeat = false; //'C'
            _rightSideAisleSeat = false; //'D'
        }
        //properties
        public bool LeftSideWindowSeat
        {
            get { return _leftSideWindowSeat; }
            set { _leftSideWindowSeat = value; }
        }
        public bool LeftSideAisleSeat
        {
            get { return _leftSideAisleSeat; }
            set { _leftSideAisleSeat = value; }
        }
        public bool RightSideWindowSeat
        {
            get { return _rightSideWindowSeat; }
            set { _rightSideWindowSeat = value; }
        }
        public bool RightSideAisleSeat
        {
            get { return _rightSideAisleSeat; }
            set { _rightSideAisleSeat = value; }
        }
        //methods
        

    }
}
