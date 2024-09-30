//A namespace is a named scope containing related 
//symbols (functions, classes, etc) grouped together
//to avoid collisions between their names and names
//of other symbols not belonging to their group.
//A symbol S declared within namespace N is refered
//using its qualified name N::S outside of N
namespace Ads
{
	class Banner
	{
	public:
		Banner(float w = 20, float h = 5) : width(w), height(h)
		{
		}

		void Resize(float w, float h) 
		{
			width = w;
			height = h;
		}

		//member function declared using 'virtual' keyword
		//supports overriding in derived class
		virtual double Price() const
		{
			float rate = width >= height ? 0.80 : 0.95;
			return width * height * rate;
		}

	private:
		float width;
		float height;
	};

	//HardBanner class is derived from Banner (base) class
	//and as such it inherits all the members of Banner
	class HardBanner : public Banner
	{
	public:
		HardBanner(float w, float h, int t) : Banner(w, h)
		{
			thickness = t;
		}

		//overriding member function base class
		double Price() const
		{
			return 0.75 * thickness * Banner::Price();
		}
	private:
		int thickness;
	};
}

