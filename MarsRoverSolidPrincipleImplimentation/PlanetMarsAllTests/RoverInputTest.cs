using System;
using NUnit.Framework;
using MarsRover;


namespace PlanetMarsAllTests
{
    [TestFixture()]
    public class RoverInputTest
    {


        /*    [Test()]
            public void To_Check_For_The_Entered_Coordinate_Rover_landing_Is_Valid()
            {
                RoverInput roverInput = new RoverInput();
                Map mars = new Map(100, 120); //co_ordinate Starts From 0  So it will go Till Length-1
                Assert.IsFalse(roverInput.IsCheckPositionOfRoverValid(100, 120));
                Assert.IsTrue(roverInput.IsCheckPositionOfRoverValid(99,119));
            }
    */


        /*	[Test()]
			public void To_Check_For_The_Movements_Of_Rover_In_Forward_Direction()
			{
				Mars mars = new Mars(100, 120);
				RoverInput roverInput = new RoverInput(50, 50);
				RoverMoment roverMovement = new RoverMoment(roverInput);
				roverMovement.Move();
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


			[Test()]
			public void To_Check_For_The_Movements_Of_Rover_In_2_Left_Direction()
			{
				Mars mars = new Mars(100, 100);
				RoverInput roverInput = new RoverInput(50, 50);
				RoverMoment roverMovement = new RoverMoment(roverInput);
				roverMovement.Left();
				roverMovement.Left();
				Assert.AreEqual(49, roverInput.XCoOrdinate);
				Assert.AreEqual(51,roverInput.YCoOrdinate);
			}*/

        [Test()]
        public void To_Check_For_The_Rotation_Of_Rover_Left()
        {
            Map map = new Map(10, 12);
            RoverInput roverInput = new RoverInput(1, 2);
            RoverMoment roverMovement = new RoverMoment(roverInput, EnumDirection.North, map);
            roverMovement.Left();
            Assert.AreEqual(EnumDirection.West, roverMovement.FacingDirection);
            roverMovement.Left();
            Assert.AreEqual(EnumDirection.South, roverMovement.FacingDirection);
            roverMovement.Right();
            Assert.AreEqual(EnumDirection.West, roverMovement.FacingDirection);

        }



        [Test()]
        public void To_Check_For_The_Movements_Of_Rover_LMLMLMLMM()
        {
            Map map = new Map(5, 5);
            RoverInput roverInput = new RoverInput(1, 2);
            RoverMoment roverMovement = new RoverMoment(roverInput, EnumDirection.North, map);
            roverMovement.Left();
            roverMovement.Move();
            roverMovement.Left();
            roverMovement.Move();
            roverMovement.Left();
            roverMovement.Move();
            roverMovement.Left();
            roverMovement.Move();
            roverMovement.Move();


            Assert.AreEqual(1, roverInput.XCoOrdinate);
            Assert.AreEqual(3, roverInput.YCoOrdinate);
            Assert.AreEqual(EnumDirection.North, roverMovement.FacingDirection);

        }

        [Test()]
        public void To_Check_For_The_Movements_Of_Rover_MMRMMRMRRM()
        {
            Map map = new Map(5, 5);
            RoverInput roverInput = new RoverInput(3, 3);
            RoverMoment roverMovement = new RoverMoment(roverInput, EnumDirection.East, map);
            roverMovement.Move();
            roverMovement.Move();
            roverMovement.Right();
            roverMovement.Move();
            roverMovement.Move();
            roverMovement.Right();
            roverMovement.Move();
            roverMovement.Right();
            roverMovement.Right();
            roverMovement.Move();


            Assert.AreEqual(5, roverInput.XCoOrdinate);
            Assert.AreEqual(1, roverInput.YCoOrdinate);
            Assert.AreEqual(EnumDirection.East, roverMovement.FacingDirection);

        }
        [Test()]
        public void To_Check_For_The_Movements_Of_Rover_MM()
        {
            Map map = new Map(5, 5);
            RoverInput roverInput = new RoverInput(1, 1);
            RoverMoment roverMovement = new RoverMoment(roverInput, EnumDirection.North, map);
            roverMovement.Move();
            roverMovement.Move();
            roverMovement.Move();
            roverMovement.Move();
            roverMovement.Move();
            roverMovement.Move();
            roverMovement.Move();
            roverMovement.Move();
            roverMovement.Move();
            roverMovement.Move();
            Assert.AreEqual(1, roverInput.XCoOrdinate);
            Assert.AreEqual(5, roverInput.YCoOrdinate);
            Assert.AreEqual(EnumDirection.North, roverMovement.FacingDirection);


        }


		[Test()]
		public void To_Check_For_The_Movements_Of_Rover_LMLMMMLRRM()
		{
			Map map = new Map(5, 6);
			RoverInput roverInput = new RoverInput(2, 3);
            RoverMoment roverMovement = new RoverMoment(roverInput, EnumDirection.South, map);
            roverMovement.Left();
			roverMovement.Move();
            roverMovement.Left();
			roverMovement.Move();
			roverMovement.Move();
            roverMovement.Left();
            roverMovement.Right();
            roverMovement.Right();
            roverMovement.Move();
			Assert.AreEqual(4, roverInput.XCoOrdinate);
			Assert.AreEqual(5, roverInput.YCoOrdinate);
            Assert.AreEqual(EnumDirection.East, roverMovement.FacingDirection);


		}
    }
}