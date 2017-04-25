#include<iostream>
#include<cstring>
using namespace std;
const char HashTable[10][5]={"", "" , "abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"};
void printWordsUtil(int number[], int curr_digit, char output[], int n)
{
	int i;
	if(n==curr_digit)
	{
		cout<<"\n"<<output;
		return;
	}
	for(i=0; i < strlen(HashTable[number[curr_digit]]) ; i++)
	{
		output[curr_digit]=HashTable[number[curr_digit]][i];
		printWordsUtil(number, curr_digit +1, output, n);
		if(number[curr_digit]==0 || number[curr_digit]==1)
			return;
	}
}
void printWords(int n, int number[])
{
	char result[n+1];
	result[n]='\0';
	printWordsUtil(number, 0, result, n);
}
int main()
{
	int number[]={2,3,4};
	int n=sizeof(number)/sizeof(number[0]);
	printWords(n,number);
	return 0;
}
