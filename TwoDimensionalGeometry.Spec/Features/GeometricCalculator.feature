Feature: Geometric Calculator

method for calculating the total area and perimeter of one or more two dimensional geometric shapes.

Background: Lisa loves to collect geometric shapes and has so far collected six of them
    Given shape 1 is a equilateral triangle whose sides are 1 cm
    And shape 2 is a isosceles triangle with a base that measures 6 cm and legs that's 5 cm
    * shape 3 is a rectangle with a width of 2 cm and a height of 4 cm
    * shape 4 is a right angle triangle with a width of 3 cm and a height of 4 cm
    * shape 5 is a square with sides 2 cm long
    * shape 6 is a circle with a radius of 1 cm


Scenario Outline: Lisa is curious about the individual areas of her shapes
    When she tests them one by one
    Then she gets the answer that the area for shape number <number> is <area>
Examples:
    | number | area  |
    | 1      | 0.433 |
    | 2      | 12    |
    | 3      | 8     |
    | 4      | 6     |
    | 5      | 4     |
    | 6      | 3.142 |

Scenario Outline: Once she's satisfied her curiousity about the areas, she also wants to find their individual perimeters
    When she tests them one by one
    Then she gets the answer that the perimeter for shape number <number> is <perimeter>
Examples:
    | number | perimeter |
    | 1      | 3         |
    | 2      | 16        |
    | 3      | 12        |
    | 4      | 12        |
    | 5      | 8         |
    | 6      | 6.283     |

Scenario: Now that Lisa know that individual areas and perimeters she wants to find out what the total area of all her shapes is
When she tests all her shapes together
Then she gets the answer that the total area is 33.57

Scenario: For completeness sake, Lisa feels obligated to also find out the total perimeter of her shapes
When she tests all her shapes together
Then she gets the answer that the total perimeter is 57.28 cm