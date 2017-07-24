using System;
namespace MarsRover
{
    public class RoverMoment
    {
        public RoverInput rover;
        public RoverMoment(RoverInput rover)
        {
            this.rover = rover;
        }
        public void Forward()
        {
            if (rover.IsCheckPositionOfRoverValid(rover.XCoOrdinate, rover.YCoOrdinate - 1))
            {
                rover.YCoOrdinate = rover.YCoOrdinate - 1;
            }

        }
        public void Backward()
        {
            if (rover.IsCheckPositionOfRoverValid(rover.XCoOrdinate, rover.YCoOrdinate + 1))
            {
                rover.YCoOrdinate = rover.YCoOrdinate + 1;
            }
        }
		public void Left()
		{
			if (rover.IsCheckPositionOfRoverValid(rover.XCoOrdinate-1, rover.YCoOrdinate))
			{
                rover.XCoOrdinate = rover.XCoOrdinate-1;
			}
		}
		public void Right()
		{
            if (rover.IsCheckPositionOfRoverValid(rover.XCoOrdinate + 1, rover.YCoOrdinate))
			{
                rover.XCoOrdinate = rover.XCoOrdinate + 1;
			}
		}

    }
}

