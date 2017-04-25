#include<iostream>
using namespace std;

#define STACKSIZE 100
class Stack
{
public:
    int s[STACKSIZE],top;
    Stack()
    {
    	top = -1;
	}
    void Push(int value)
	{		
		if (top + 1 < STACKSIZE)
		{
			top++;		
			s[top]=value;
			cout<<"The value"<<s[top]<<"is pushed in the stack";
		}
		else
		{
			cout<<"Stack overflow!";
		}
		
	}
    void Pop()
	{
		if(top!=-1)
		{
		    top--;
			cout<<"The current top value is"<<s[top];
		}
		else
			cout<<"Stack is empty";
	}	
};
int main()
{
	int no,op=1;
	cout<<"STACK IMPLEMENTATION";
	
	Stack s1;
	
	while(op != 0)
	{
		cout<<"\n Enter any option from below:\n1.Push\n2.Pop\n.0.Exit ";
	    cin>>op;
	if (op==1)
	{
		cout<<"Enter the value to be pushed:";
	    cin>>no;
		s1.Push(no);
		
    }
    else if (op == 2) 
    {
     	s1.Pop();
		
    }
    
	}
	return 0;
}
