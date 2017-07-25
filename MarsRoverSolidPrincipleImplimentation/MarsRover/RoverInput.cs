using System;
namespace MarsRover
{
    public class RoverInput
    {
        public int XCoOrdinate { get; set; }
        public int YCoOrdinate { get; set; }


        public RoverInput(int XCoOrdinate = 0 , int YCoOrdinate = 0)
        {
            this.XCoOrdinate = XCoOrdinate;
            this.YCoOrdinate = YCoOrdinate;
        }
        public bool IsCheckPositionOfRoverValid(Map mars,int XCoOrdinate = 0 , int YCoOrdinate = 0)
        {
            bool isValidXCoOrdinate = XCoOrdinate >= 0 && XCoOrdinate <= mars.Length;
            bool isValidYCoOrdinate = YCoOrdinate >= 0 && YCoOrdinate <= mars.Breadth;
            if(isValidXCoOrdinate && isValidYCoOrdinate)
            {
                return true;

            }
            return false;

        }
    }
}
