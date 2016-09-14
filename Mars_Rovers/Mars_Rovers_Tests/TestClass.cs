using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Moq;
using Mars_Rovers_Library;

namespace Mars_Rovers_Tests
{
    [TestFixture]
    public class TestClass
    {
        private Mock<IPosition> _position = null;
        private Mock<IPlateau> _pleateau = null;
        private IRover _roverOne = null;
        private IRover _roverTwo = null;

        [SetUp]
        public void Setup()
        {
            _pleateau = new Mock<IPlateau>();
            _position = new Mock<IPosition>();
        }

        private void SetupRoverOne()
        {
            _position.SetupProperty(x => x.X, 1);
            _position.SetupProperty(x => x.Y, 2);
            _pleateau.Setup(x => x.PlateauPosition).Returns(new Position(6, 6));
            _roverOne = new Rover(_position.Object, Mars_Rovers_Library.Rover.Orientations.N, _pleateau.Object);
        }

        private void SetupRoverTwo()
        {
            _position.SetupProperty(x => x.X, 2);
            _position.SetupProperty(x => x.Y, 2);
            _pleateau.Setup(x => x.PlateauPosition).Returns(new Position(6, 6));
            _roverTwo = new Rover(_position.Object, Mars_Rovers_Library.Rover.Orientations.E, _pleateau.Object);
        }


        [Test]
        public void RoverOneOutput()
        {
            //Arrange
            SetupRoverOne();

            //Act
            _roverOne.Process("MLRMRLMM");

            //Assert
            Console.WriteLine(_roverOne.ToString());
            Assert.AreEqual(_roverOne.ToString(), "1 6 N");
        }

        [Test]
        public void RoverTwoOutput()
        {
            //Arrange
            SetupRoverTwo();

            //Act
            _roverTwo.Process("MRMLRMRM");

            //Assert
            Console.WriteLine(_roverTwo.ToString());
            Assert.AreEqual(_roverTwo.ToString(), "2 0 W");
        }


    }
}
