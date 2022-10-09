namespace CalcAreaFigures.Tests
{
    [TestClass]
    public class CalcAreaFiguresTests
    {
        [TestMethod]
        public void CalculateArea_CreateNewFigureAndCalculateArea_InstanceClassResult() {
            // Arrange
            string nameFigure = "Rhomb";
            List<double> listParameters = new List<double>();
            listParameters.Add(4);
            listParameters.Add(8.33);
            double expected = 14.221;

            // Act
            CalcArea rhomb = new CalcArea(nameFigure, listParameters);
            double actual = Math.Round(rhomb.CalculateArea(), 3, MidpointRounding.AwayFromZero);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcArea_CreateNewFigure_ValidateName() {
            // Arrange
            string nameFigure = "cIR Cle";
            List<double> listParameters = new List<double>();
            listParameters.Add(7);
            string expected = "Circle";

            // Act
            CalcArea circle = new CalcArea(nameFigure, listParameters);
            string actual = circle.Name;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isRightTriangle_TriangleRight_TrueReturn() {
            // Arrange
            string nameFigure = "Triangle";
            List<double> listParameters = new List<double>();
            listParameters.Add(3);
            listParameters.Add(4);
            listParameters.Add(5);

            // Act
            CalcArea triangle = new CalcArea(nameFigure, listParameters);
            bool actual = triangle.isRightTriangle();

            // Assert
            Assert.IsTrue(actual);
        }
    }
}