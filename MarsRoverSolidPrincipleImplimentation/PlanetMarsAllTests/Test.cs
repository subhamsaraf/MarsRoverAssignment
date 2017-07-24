using NUnit.Framework;
using System;
using MarsRover;

namespace PlanetMarsAllTests
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void To_Check_For_The_Entered_Length_Of_Planet_Mars()
        {
            Mars mars = new Mars(100, 150);

            Assert.AreNotEqual(150, mars.Length);
            Assert.AreEqual(100, mars.Length);
        }


        [Test()]
        public void To_Check_For_The_Entered_Breadth_Of_Planet_Mars()
        {
            Mars mars = new Mars(100, 150);

            Assert.AreNotEqual(100, mars.Breadth);
            Assert.AreEqual(150, mars.Breadth);
        }

		[Test()]
		public void To_Check_For_The_Entered_Breadth_Of_Planet_()
		{
			Mars mars = new Mars(100, 150);

			Assert.AreNotEqual(100, mars.Breadth);
			Assert.AreEqual(150, mars.Breadth);
		}

	}   

}
