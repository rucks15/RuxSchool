#include<iostream>
using namespace std;
int main()
{
	int i=0,j=0,n=0,key=0;
	int a[50];
	cout<<"Insertion Sort";
	cout<<"\n Enter the number of values:";
	cin>>n;
	cout<<"\n Enter the values:";
	for (i=0; i<n; i++)
	{
		cin>>a[i];
	}
	cout<<"\n Given array is:";
	for(i=0;i<n;i++)
	{
		cout<<a[i];
	}
	for(i=1;i<n;i++)
	{
	    key=a[i];
		j=i-1;
		while((j>=0)&&(a[j]>key))
		{
			a[j+1]=a[j];
			j=j-1;
		}
		a[j+1]=key;
	}
	cout<<"\n Sorted array is:";
	for(i=0;i<n;i++)
	{
		cout<<"\n"<<a[i];
	}
	return 0;
}
