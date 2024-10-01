#include "boards.h"

#define PI 3.14

namespace Ads
{
	double Signboard::Price() const
	{
		return 0.95 * material * Area();
	}

	RectangularBoard::RectangularBoard(float length, float breadth, Medium make)
	{
		width = length;
		height = breadth;
		material = make;
	}

	double RectangularBoard::Area() const
	{
		return width * height;
	}

	CircularBoard::CircularBoard(float diameter, Medium make)
	{
		radius = diameter / 2;
		material = make;
	}

	double CircularBoard::Area() const
	{
		return PI * radius * radius;
	}

	double CircularBoard::Scrap() const
	{
		return (4 - PI) * radius * radius * material;
	}
};

