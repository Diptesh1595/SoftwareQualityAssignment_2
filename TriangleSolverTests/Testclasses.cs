using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;

namespace TriangleSolverTests
{
    [TestFixture]
    public class Testclasses
    {
        //  Unit tests for equilateral triangle
        [Test]
        public void CheckTriangleType_ValidEquilateral()
        {
            // Arrange
            int side1 = 8;
            int side2 = 8;
            int side3 = 8;
            string expected = "Equilateral triangle";


            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }


        //  Unit tests for isosceles triangles
        [Test]
        public void CheckTriangleType_ValidIsosceles1()
        {
            // Arrange
            int side1 = 5;
            int side2 = 5;
            int side3 = 8;
            string expected = "Isosceles triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CheckTriangleType_ValidIsosceles2()
        {
            // Arrange
            int side1 = 9;
            int side2 = 4;
            int side3 = 9; 
            string expected = "Isosceles triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CheckTriangleType_ValidIsosceles3()
        {
            // Arrange
            int side1 = 1;
            int side2 = 7;
            int side3 = 7; 
            string expected = "Isosceles triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }



        // Unit tests for scalene triangles
        [Test]
        public void CheckTriangleType_ValidScalene1()
        {
            // Arrange
            int side1 = 3;
            int side2 = 4;
            int side3 = 5;
            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CheckTriangleType_ValidScalene2()
        {
            // Arrange
            int side1 = 2;
            int side2 = 8;
            int side3 = 7; 
            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CheckTriangleType_ValidScalene3()
        {
            // Arrange
            int side1 = 9;
            int side2 = 11;
            int side3 = 12; 
            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CheckTriangleType_ValidScalene4()
        {
            // Arrange
            int side1 = 10;
            int side2 = 12;
            int side3 = 13; 
            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CheckTriangleType_ValidScalene5()
        {
            // Arrange
            int side1 = 6;
            int side2 = 5;
            int side3 = 4; 
            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        // Unit tests for zero length sides
        [Test]
        public void CheckTriangleType_ZeroSide1()
        {
            // Arrange
            int side1 = 0;
            int side2 = 5;
            int side3 = 5;
            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CheckTriangleType_ZeroSide2()
        {
            // Arrange
            int side1 = 5;
            int side2 = 0;
            int side3 = 5;
            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CheckTriangleType_ZeroSide3()
        {
            // Arrange
            int side1 = 5;
            int side2 = 5;
            int side3 = 0;
            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }


        // Unit tests for invalid triangles
        [Test]
        public void CheckTriangleType_InvalidSides1()
        {
            // Arrange
            int side1 = 1;
            int side2 = 2;
            int side3 = 8;
            string expected = "INVALID!!";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CheckTriangleType_InvalidSides2()
        {
            // Arrange
            int side1 = 2;
            int side2 = 5;
            int side3 = 8; 
            string expected = "INVALID!!";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CheckTriangleType_InvalidSides3()
        {
            // Arrange
            int side1 = 5;
            int side2 = 1;
            int side3 = 1; 
            string expected = "INVALID!!";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
 }



