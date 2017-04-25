#include<iostream>
#include<cstring>
#include<string>
using namespace std;
const char * const printArray[50]={"zero","one", "two", "three","four","five","six","seven","eight","nine","ten","eleven","twelve","thirteen","fourteen",
	"fifteen","sixteen","seventeen","eighteen","nineteen","twenty","thirty","fourty","fifty","sixty","seventy","eighty","ninety"};
void twoDigits(int *a)
{
	int n,i=1;
	if((a[i+1] == 0)&&(a[i]>0))
		cout<<""<<printArray[a[1]];
	if ((a[i+1] == 1)&&(a[i]>=0))
	{
		n = a[i] + 10;
		cout<<""<<printArray[n];
	}
	if((a[i+1]>1) && (a[i]==0))
	{
		n=18+a[i+1];
		cout<<""<<printArray[n];
	}
	if((a[i+1]>=2) &&(a[i]>=1))
	{
		n=a[i+1]+18;
		string str1=printArray[n];
		string str2=printArray[a[i]];
		cout<<str1<<" "<<str2;
	}
}

void threeDigits(int *a)
{
	int b[5];
	if((a[2]==0) && (a[1]==0))
	{
		cout<<"\n"<< printArray[a[3]]<<" Hundred";
	}
	else if(a[3]!=0)
	{
		cout<<printArray[a[3]]<<" hundred and ";
		b[1]=a[1];
		b[2]=a[2];
		twoDigits(b);
	}
	else
	{
		b[1]=a[1]; b[2]=a[2];
		twoDigits(b);
	}
}

void fourDigits(int *a)
{
	int b[5];
	if((a[2]==0) && (a[1]==0) && (a[3]==0))
	{
		if(a[4]==0)
			cout<<"\n"<<printArray[(a[5]+9)]<<" Thousand";
		else
			cout<<"\n"<<printArray[(a[4]+10)]<<" Thousand";
	}
	else
	{
		b[1]=a[4];
		b[2]=a[5];
		twoDigits(b);
		cout<<" thousand and ";
		threeDigits(a);
	}	
}

int main()
{
	
	int n,digits=1,value1,a[20];
	cout<<" Print given number into words";
	cout<<"\n Enter the number:";
	cin>>n;
	while(n > 9)
	{
		value1 = n % 10;
		a[digits++]=value1;
		n = n / 10;
	}
	a[digits]=n;
	if(digits==1)
	   cout<<"\n"<<printArray[n];
	if(digits==2)
		twoDigits(a);
	if(digits==3)
		threeDigits(a);
	if((digits==4) || (digits==5))
		fourDigits(a);
	return 0;	
}
