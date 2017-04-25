#include<iostream>
#include<stdio.h>
#include<string.h>
using namespace std;
void reverse(char *begin, char *end)
{
	char temp;
	while(begin < end)
	{
		temp = *begin;
		*begin++ = *end;
		*end-- = temp;
	}
}
void reverseWords(char *s)
{
	char *wordBegin=NULL;
	char *temp=s;
	while( *temp )
	{
		if ((wordBegin == NULL) && (*temp != ' '))
		{
	     wordBegin=temp;
	    }
		if(wordBegin && ((*(temp+1)=='\0') || (*(temp+1) == ' ')))
		{
			reverse(wordBegin,temp);
			wordBegin=NULL;
		}
		temp++;
	}
	reverse(s,temp-1);
}

void Swap(char* a, char* b)
{
	char temp = *a;
	*a = *b;
	*b = temp;
}

int main()
{
	cout<<"Reverse words in a string";
	char s[]="Hello How are you";
	// char *temp=s;
	// reverseWords(s);
	// cout<<s;
	cout<<"\n";
	int length = strlen(s);
	for (int i=0, j = length-1; i<j; i++, j--)
	{
		Swap(s+i, s+j);
	}
	cout<<s<<"\n";
	
	int startIndex = 0;
	bool startIndexSet = true;
	for (int i=0; i<length+1;i++)
	{
		if (s[i] == ' ' || s[i] == '\0')
		{
			for (int k = startIndex, l = i-1; k<l; k++, l--)			
			{
				Swap(s+k, s+l);
			}
			startIndexSet = false;
		}
		else
		{
			if (!startIndexSet)
			{
				startIndexSet = true;
				startIndex = i;
			}
		}
	}
	cout<<s;
	return 0;
}


