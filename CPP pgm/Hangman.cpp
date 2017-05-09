#include<iostream>
#include<string>
using namespace std;
int main()
{
	string str="old is gold";
	char input;
	char op[50]={0};
	bool check=false;
	int count=0,count1=0,string_length=0;
	cout<<"HANG MAN \n\n\t\t\t ";
	for(int i=0; i<str.length();i++)
	{
		if(str[i]==' ')
			cout<<" ";
		else
		{
			string_length++;
			cout<<"-";
		}
	}
	cout<<"\n Total String Length:"<<string_length;
	//Loop begins if the count is less than 5 and there are characters to check in the word.
	while((count<5)&&(string_length!=0))
	{
		cout<<"\n \n Enter the character:";
		cin>>input;
		//checks whether the given input is already validated and present in the output array or not
		for(int j=0; j<str.length();j++)
		{
			if(input==op[j])
			{
				check=true;
				break;
			}
			else
				check=false;
		}
		//If the input is not in the output array, the loop begins to check the character with the word
		if(check==false)
		{
			for(int i=0; i<str.length();i++)
			{
				if(str[i]==input)
				{
					count1+=1;
					string_length--;
					op[i]=str[i];
					cout<<op[i];
				}
				if(str[i]==' ')
				{
					op[i]=' ';
					cout<<op[i];
				}
			}
			if(count1==0)
			{
				cout<<"\n Wrong guess";
				count += 1;
				cout<<"\n Missed "<<count<<" chances of 5";
			}
			else
			{
				cout<<"\n Letter is present "<<count1<< "times \n";		
				count1=0;
			}
			cout<<"\n Remaining letters in the word: "<< string_length <<endl;
		}
	}
	for(int j=0; j<str.length();j++)
		cout<<op[j];
	if(count==5)
		cout<<"\n You missed your chances of finding the word";
	else 
		cout<<"\n You found the word";
	return 0;
}
