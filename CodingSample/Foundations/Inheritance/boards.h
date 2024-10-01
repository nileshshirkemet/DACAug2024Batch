namespace Ads
{
	enum Medium {Plastic = 1, Wood = 2, Metal = 5};

	class Signboard
	{
	public:
		//A pure virtual member function must be overridden
		//in the derived class. A class that contains at least
		//one pure virtual member function is known as an
		//abstract data type (ADT) and such a class cannot
		//be instantiated, it can only be used as a pointer
		//or a reference type.
		virtual double Area() const = 0;
		double Price() const;
	protected: //members is also visible in a derived class
		Medium material;	
	};

	class Wasteful
	{
	public:
		virtual double Scrap() const = 0;
	};

	class RectangularBoard : public Signboard
	{
	public:
		RectangularBoard(float length, float breadth, Medium make);
		double Area() const;
	private:
		float width, height;
	};

	//multiple inheritance
	class CircularBoard : public Signboard, public Wasteful
	{
	public:
		CircularBoard(float diameter, Medium material);
		double Area() const;
		double Scrap() const;
	private:
		float radius;
	};
}

