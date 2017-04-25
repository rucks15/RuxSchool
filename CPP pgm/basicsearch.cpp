#include<iostream>
using namespace std;
int main()
{
	int a[10]={1,2,3,4,5,6,7,8,9,10};
	int no,flag=0;
	cout<<"SEARCHING";
	cout<<"The number array";
	for(int i=0;i<10;i++)
	{
		cout<<a[i];
	}
	cout<<"\nEnter the value to be searched: ";
	cin>>no;
	for(int i=0;i<10;i++)
	{
		
		if(a[i]==no)
		{
			flag=1;
			cout<<"The number is present";
			break;
		}
		flag=0;
	}
	if(flag==0)
	cout<<"\n The number entered is not present";
return 0;
}
