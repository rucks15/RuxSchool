#include<iostream>
#include<cmath>
using namespace std;
int main()
{
	int h,m,s,option;
	float hr, min, angle;
	cout<<"\n Enter the value of hour:";
	cin>>h;
	cout<<"\n Enter the value of minute:";
	cin>>m;
	cout<<"\n Enter the value of seconds:";
	cin>>s;
	hr=((h*30)+( (m*30)/60 ));
	min=((m*6)+((s*6)/60));
	angle=abs(hr-min); 
	if(angle>180)
	angle=360-angle;
	cout<<"\n Angle between hour and minute hand is :"<<angle;
	

	return 0;
}

