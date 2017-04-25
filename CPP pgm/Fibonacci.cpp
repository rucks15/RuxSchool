#include<iostream>
using namespace std;
int Fibonacci(int);
int main()
{
	int n,result;
	cout<<"Redursion";
	cout<<"Enter the number:";
	cin>>n;
	result=Fibonacci(n);
	cout<<"Result:"<<result;
	return 0;
}
int Fibonacci (int n)
{
	if(n==1)
	return 1;
	else
	n=n*(Fibonacci(n-1));
	
    return n;

}
