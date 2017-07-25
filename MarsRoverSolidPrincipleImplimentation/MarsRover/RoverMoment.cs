using System;
namespace MarsRover
{
    public class RoverMoment
    {
        public RoverInput rover;
        public EnumDirection FacingDirection
        {
            get;
            private set;
        }
        public RoverMoment(RoverInput rover)
        {
            this.rover = rover;
        }


        public void Left()
        {
            int direction = (int)FacingDirection;
            direction = (direction + 3)%4;
            FacingDirection = (EnumDirection)direction;
            Forward();
        }

        public void Right()
        {
            int direction = (int)FacingDirection;
            direction = (direction + 1) % 4;
            FacingDirection = (EnumDirection)direction;
            Forward();
        }
        public void Backward()
        {
            int direction = (int)FacingDirection;
            direction = (direction + 2) % 4;
            FacingDirection = (EnumDirection)direction;
            Forward();
        }


        public void Forward()
        {
            if (FacingDirection == EnumDirection.North)
            {
                if (rover.IsCheckPositionOfRoverValid(rover.XCoOrdinate, rover.YCoOrdinate - 1))
                {
                    rover.YCoOrdinate = rover.YCoOrdinate - 1;
                }
            }

            if (FacingDirection == EnumDirection.South)
            {
                if (rover.IsCheckPositionOfRoverValid(rover.XCoOrdinate, rover.YCoOrdinate + 1))
                {
                    rover.YCoOrdinate = rover.YCoOrdinate + 1;
                }
            }
            if (FacingDirection == EnumDirection.West)
            {
                if (rover.IsCheckPositionOfRoverValid(rover.XCoOrdinate - 1, rover.YCoOrdinate))
                {
                    rover.XCoOrdinate = rover.XCoOrdinate - 1;
                }
            }
            if (FacingDirection == EnumDirection.East)
            {
                if (rover.IsCheckPositionOfRoverValid(rover.XCoOrdinate + 1, rover.YCoOrdinate))
                {
                    rover.XCoOrdinate = rover.XCoOrdinate + 1;
                }
            }
		}

    }
}

