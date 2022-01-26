using System;
using TechTalk.SpecFlow;
using TwoDimensionalGeometry.Interfaces;
using TwoDimensionalGeometry.Spec.Support;

namespace TwoDimensionalGeometry.Spec.StepDefinitions
{
    [Binding]
    public class GeometricCalculatorStepDefinitions
    {
        private readonly GeoCalcTestObject geoCalcTest = new();

        [Given(@"shape 1 is a equilateral triangle whose sides are (\d+) cm")]
        public void GivenThatSheHasAEquilateralTriangleWhoseSidesAreCm(float sides) => geoCalcTest.Shapes.Add(new EquilateralTriangle(sides));

        [Given(@"shape 2 is a isosceles triangle with a base that measures (\d+) cm and legs that's (\d+) cm")]
        public void GivenSheHasAIsoscelesTriangleWithABaseThatMeasuresCmAndLegsThatsCm(float tbase, float legs) => geoCalcTest.Shapes.Add(new IsoscelesTriangle(tbase, legs));

        [Given(@"shape 3 is a rectangle with a width of (\d+) cm and a height of (\d+) cm")]
        public void GivenSheHasARectangleWithABaseOfCmAndAHeightOfCm(float width, float heigth) => geoCalcTest.Shapes.Add(new Rectangle(heigth, width));

        [Given(@"shape 4 is a right angle triangle with a width of (\d+) cm and a height of (\d+) cm")]
        public void GivenSheHasARightAngleTriangleWithABaseOfCmAndAHeightOfCm(float width, float heigth) => geoCalcTest.Shapes.Add(new RightAngleTriangle(heigth, width));

        [Given(@"shape 5 is a square with sides (\d+) cm long")]
        public void GivenSheHasASquareWithSidesCmLong(float side) => geoCalcTest.Shapes.Add(new Square(side));
        [Given(@"shape 6 is a circle with a radius of (\d+) cm")]
        public void GivenSheHasACircleWithARadiusOfCm(float radius) => geoCalcTest.Shapes.Add(new Circle(radius));

        [When("she tests them one by one")]
        public void WhenSheTestsThemOneByOne()
        {
            foreach (var shape in geoCalcTest.Shapes)
            {
                geoCalcTest.ResultsArea.Add(GeometricCalculator.GetArea(shape));
                geoCalcTest.ResultsPerimeter.Add(GeometricCalculator.GetPerimeter(shape));
            }
        }

        [Then("she gets the answer that the area for shape number (.*) is (.*)")]
        public void ThenSheGetsTheAnswerThatTheAreaIs(int number,float area)
        {
            var expected = (float)Math.Round(geoCalcTest.ResultsArea[number-1],3);
            expected.Should().Be(area);
        }
        [Then("she gets the answer that the perimeter for shape number (.*) is (.*)")]
        public void ThenSheGetsTheAnswerThatThePerimeterForShapeNumberIs(int number, float perimeter)
        {
            var expected = (float) Math.Round(geoCalcTest.ResultsPerimeter[number - 1], 3);
            expected.Should().Be(perimeter);
        }
        [When("she tests all her shapes together")]
        public void WhenSheTestsAllHerShapesTogether()
        {
            geoCalcTest.TotalArea = GeometricCalculator.GetArea(geoCalcTest.Shapes);
            geoCalcTest.TotalPerimeter = GeometricCalculator.GetPerimeter(geoCalcTest.Shapes);
        }

        [Then("she gets the answer that the total area is (.*)")]
        public void ThenSheGetsTheAnswerThatTheTotalAreaIs(float expectedTotalArea)
        {
            var totalArea = (float)Math.Round(geoCalcTest.TotalArea,2);
            totalArea.Should().Be(expectedTotalArea);
        }
        [Then(@"she gets the answer that the total perimeter is (\d+\.{0,1}\d*) cm")]
        public void ThenSheGetsTheAnswerThatTheTotalPerimeterIs(float expectedTotalPerimeter)
        {
            var totalPerimeter = (float) Math.Round(geoCalcTest.TotalPerimeter, 2);
            totalPerimeter.Should().Be(expectedTotalPerimeter);
        }
    }
}
