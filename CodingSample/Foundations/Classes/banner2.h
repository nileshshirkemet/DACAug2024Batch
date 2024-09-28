enum Geometry {Rectangular, Triangular, Elliptical};

class Banner
{
public:

	Banner()
	{
		region = 20.0 * 5.0;
		shape = Geometry::Rectangular;
	}

	void Resize(float w, float h)
	{
		region = w * h;
	}	
	
	void Reshape(Geometry s)
	{
		shape = s;
	}

	double Price() const
	{
		float rate = region >= 100 ? 0.80 : 0.95;
		float wastage;
		switch(shape)
		{
			case Geometry::Triangular:
				wastage = 0.5;
				break;
			case Geometry::Elliptical:
				wastage = 0.22;
				break;
			default:
				wastage = 0;
		}
		return region * rate * (1 - 0.6 * wastage);
	}

private:
	float region;
	Geometry shape;
};

