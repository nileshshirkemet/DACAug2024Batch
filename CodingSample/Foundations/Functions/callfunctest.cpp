#includcstdio>

double BannerPrice(float width, float height)
{
	float rate = width > height ? 0.80 : 0.95;
	return width * height * rate;
}

int main(void)
{
	float w, h;
	int n;

	printf("Dimensions of Banner: ");
	scanf("%f%f", &w, &h);
	printf("Number of Banners   : ");
	scanf("%d", &n);

	double payment = n * BannerPrice(w, h);

	printf("Total Payment: %.2lf\n", payment);
}


