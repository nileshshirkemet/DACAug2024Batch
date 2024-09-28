class Banner
{
public:

	//A constructor is a member-function (method) whose name matches
	//with the name of the class and is declared without a return type.
	//A constructor which does not take any parameter or has all optional
	//parameters is called a default contructor.
	Banner()
	{
		width = 20.0;
		height = 5.0;
	}

	//void Banner::Resize(Banner* this, float w, float h)
	void Resize(float w, float h)
	{
		width = w; //this[0].width = w;
		height = h; //this[0].height = h;
	}	
	
	//a pointer declared with const qualifier cannot be used
	//to modify the value addressed by by that pointer
	//double Banner::Price(const Banner* this)
	double Price() const
	{
		//float rate = this[0].width * this[0].height >= 100 ? 0.80 : 0.95;
		float rate = width * height >= 100 ? 0.80 : 0.95;
		//return this[0].width * this[0].height * rate;
		return width * height * rate;
	}

private:
	float width;
	float height;
};

