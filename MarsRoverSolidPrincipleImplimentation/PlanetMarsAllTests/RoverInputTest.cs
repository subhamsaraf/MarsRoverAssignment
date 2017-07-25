using System;
using NUnit.Framework;
using MarsRover;


namespace PlanetMarsAllTests
{
    [TestFixture()]
    public class RoverInputTest
    {


        [Test()]
        public void To_Check_For_The_Entered_Coordinate_Rover_landing_Is_Valid()
        {
            RoverInput roverInput = new RoverInput();
            Mars mars = new Mars(100, 120); //co_ordinate Starts From 0  So it will go Till Length-1
            Assert.IsFalse(roverInput.IsCheckPositionOfRoverValid(100, 120));
            Assert.IsTrue(roverInput.IsCheckPositionOfRoverValid(99,119));
        }



		[Test()]
		public void To_Check_For_The_Movements_Of_Rover_In_Forward_Direction()
		{
			Mars mars = new Mars(100, 120);
            RoverInput roverInput = new RoverInput(50, 50);
            RoverMoment roverMovement = new RoverMoment(roverInput);
            roverMovement.Forward();
            Assert.AreEqual(49,roverInput.YCoOrdinate);
		}



		[Test()]
		public void To_Check_For_The_Movements_Of_Rover_In_Backward_Direction()
		{
			Mars mars = new Mars(100, 120);
			RoverInput roverInput = new RoverInput(50, 50);
			RoverMoment roverMovement = new RoverMoment(roverInput);
            roverMovement.Backward();
			Assert.AreEqual(51, roverInput.YCoOrdinate);
		}



        [Test()]
        public void To_Check_For_The_Movements_Of_Rover_In_Left_Direction()
		{
			Mars mars = new Mars(100, 120);
			RoverInput roverInput = new RoverInput(50, 50);
			RoverMoment roverMovement = new RoverMoment(roverInput);
            roverMovement.Left();
            Assert.AreEqual(49, roverInput.XCoOrdinate);
		}



		[Test()]
		public void To_Check_For_The_Movements_Of_Rover_In_Right_Direction()
		{
			Mars mars = new Mars(100, 120);
			RoverInput roverInput = new RoverInput(50, 50);
			RoverMoment roverMovement = new RoverMoment(roverInput);
            roverMovement.Right();
            Assert.AreEqual(51, roverInput.XCoOrdinate);
		}

		[Test()]
		public void To_Check_For_The_Movements_Of_Rover_In_Right_Direction_In_1_Tile()
		{
			Mars mars = new Mars(1,1);
			RoverInput roverInput = new RoverInput(0, 0);
			RoverMoment roverMovement = new RoverMoment(roverInput);
			roverMovement.Right();
			Assert.AreEqual(1, roverInput.XCoOrdinate);
		}

		[Test()]
		public void To_Check_For_The_Movements_Of_Rover_In_2_Right_Direction()
		{
			Mars mars = new Mars(100, 100);
			RoverInput roverInput = new RoverInput(50, 50);
			RoverMoment roverMovement = new RoverMoment(roverInput);
			roverMovement.Right();
            roverMovement.Right();
			Assert.AreEqual(51, roverInput.XCoOrdinate);
            Assert.AreEqual(51,roverInput.YCoOrdinate);
		}

    }
}
