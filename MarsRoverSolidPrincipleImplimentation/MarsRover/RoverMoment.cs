using System;
namespace MarsRover
{
    public class RoverMoment
    {
        public RoverInput rover;
        public Map mars;

        public EnumDirection FacingDirection
        {
            get;
            private set;
        }
        public RoverMoment(RoverInput rover,EnumDirection initialDirection,Map mars)
        {
            this.rover = rover;
            FacingDirection = initialDirection;
            this.mars = mars;

        }


        public void Left()
        {
            int direction = (int)FacingDirection;
            direction = (direction + 3)%4;
            FacingDirection = (EnumDirection)direction;
        }

        public void Right()
        {
            int direction = (int)FacingDirection;
            direction = (direction + 1) % 4;
            FacingDirection = (EnumDirection)direction;
        }

        public void Move()
        {
            if (FacingDirection == EnumDirection.North)
            {
                if (rover.IsCheckPositionOfRoverValid(mars,rover.XCoOrdinate, rover.YCoOrdinate + 1))
                {
                    rover.YCoOrdinate = rover.YCoOrdinate + 1;
                }
            }

            if (FacingDirection == EnumDirection.South)
            {
                if (rover.IsCheckPositionOfRoverValid(mars,rover.XCoOrdinate, rover.YCoOrdinate - 1))
                {
                    rover.YCoOrdinate = rover.YCoOrdinate - 1;
                }
            }
            if (FacingDirection == EnumDirection.West)
            {
                if (rover.IsCheckPositionOfRoverValid(mars,rover.XCoOrdinate - 1, rover.YCoOrdinate))
                {
                    rover.XCoOrdinate = rover.XCoOrdinate - 1;
                }
            }
            if (FacingDirection == EnumDirection.East)
            {
                if (rover.IsCheckPositionOfRoverValid(mars,rover.XCoOrdinate + 1, rover.YCoOrdinate))
                {
                    rover.XCoOrdinate = rover.XCoOrdinate + 1;
                }
            }
		}

    }
}

