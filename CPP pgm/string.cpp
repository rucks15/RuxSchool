#include<iostream>
#include <string.h>
using namespace std;
# define STACKSIZE 50
class Stack
{
	public:
	char s[STACKSIZE];
	int top;
	Stack()
    {
    	 top = -1;
	}
    void Push(char value)
	{		
		if (top + 1 < STACKSIZE)
		{
			top++;		
			s[top]=value;
			cout<<"\n The value"<<s[top]<<"is pushed in the stack";
		}
		else
		{
			cout<<"\n Stack overflow!";
		}
		
	}
    void Pop()
	{
		if(top!=-1)
		{
		    top--;
			cout<<"\n The current top value is"<<s[top];
		}
		else
			cout<<"\n Stack is empty";
	}	
	
};
int main()
{	char stringInput[STACKSIZE];
	Stack s1;
	cout<<"\n String";
	cout<<"\n Enter the string:";
	cin>>stringInput;
	for(int i=0;i<strlen(stringInput);i++)
	{
		char a =stringInput[i]; //store the individual character in an array to perform any operation
		if(a == '(')
		s1.Push(a);
		else if(a == ')')
		s1.Pop();
		else
		continue;
	}
	if(s1.top==-1)
	cout<<"\n The string has no missing paranthesis";
	else
	cout<<"\n The string has missing paranthesis";
	return 0;
}
