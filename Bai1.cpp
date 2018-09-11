#include<stdio.h>

void nhap(int &n);
void xuat(int kq);
long laNT(long x);
long kiemtra(int n);

void main()
{
	int n;
	nhap(n);
	long kq=kiemtra(n);
	xuat(kq);
}

long kiemtra(int n)
{
	long k=1;
	while(n>0)
	{
		k=k*10;
		n--;
	}
	for(long i=k;i>0;i--)
		if(laNT(i))
			return i;
	return 0;
}

void nhap(int &n)
{
	scanf("%d",&n);
}

void xuat(int kq)
{
	printf("%d ",kq);
}

long laNT(long x)
{
	int d=0;
	for(long i=1;i<=x;i++)
	{
		if(x%i==0)
			d++;
	}
	if(d==2)
		return 1;
	return 0;
}