#include<iostream>
#include <string.h>
using namespace std;
# define STACKSIZE 50
class Stack
{
	public:
	char s[STACKSIZE];
	int top;
	Stack() //Constructor for the class
    {
    	 top = -1;
	}
    void Push(char value)
	{		
		if (top + 1 < STACKSIZE)
		{
			++top;		
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
		    --top;
			cout<<"\n The current top value is"<<s[top];
		}
		else
			cout<<"\n Stack is empty";
	}	
	
};
int main()
{	char stringInput[STACKSIZE]; //STACKSIZE defined as pre-processor directives
	Stack s1;
	cout<<"\n Find Missing Paranthesis in the string \n";
	cout<<"\n Enter the string:";
	cin>>stringInput;
	for(int i=0;i<strlen(stringInput);i++)
	{
		char a =stringInput[i]; //store the individual character in an array to perform any operation
		if(a == '(')
			s1.Push(a);
		if((a == ')') && (s1.top != -1)) //checks stack is not empty before popping an element
			s1.Pop();
		else if((a==')') && (s1.top == -1)) // stack is empty, so loop is breaked
		{
			s1.top=-2;
			break;
		}
		else
		continue;
		
	}
	if(s1.top==-1)
	cout<<"\n The string has no missing paranthesis";
	else
	cout<<"\n The string has missing paranthesis";
	return 0;
}
