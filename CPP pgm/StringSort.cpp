#include<iostream>
#include<string>
using namespace std;

string merge(string str1, string str2) 
{
  string final = "";
  int i = 0, j = 0;
  bool fromStr1 = false;

  while (true) 
  {
    if (i >= (int)str1.size()) 
	{
      break;
    }
    if (j >= (int)str2.size()) 
	{
      fromStr1 = true; // changed the order of this with break!
      break;
    }

    if (str1[i] < str2[j]) {
      final += str1[i];
      i++;
    }
    else 
	{
      final += str2[j];
      j++;
    }
  }

  if (fromStr1) 
  {
    for (int t = i; t < (int)str1.size(); t++) 
	{
      final += str1[t];
    }
  }
  else 
  {
    for(int t = j; t < (int)str2.size(); t++) 
	{
      final += str2[t];
    }
  }

  return final;
}

string mergeSort(string str1) 
{
  int len = str1.size();
  if (len <= 1)
    return str1;
  else 
  {
    string newStr1 = mergeSort(str1.substr(0, len / 2));
    string newStr2 = mergeSort(str1.substr(len / 2, len - len / 2));
    return merge(newStr1, newStr2);
  }
}

int main()
{
	string str,str1;
	bool isUnique=true, isPalindrome=true;
  	cout<<"Enter the string:";
  	getline(cin,str);
  	cout<<"Enter another string:";
  	getline(cin,str1);
  	str = mergeSort(str);
  	str1=mergeSort(str1);
  	cout << '"' << "Sorted string: "<< str << '"' << endl;
  	cout << '"' << "Sorted string 2 : "<< str1 << '"' << endl;
  	for(int i=0; i<str.size();i++) //checks duplicate characters in given string
  	{
  		if(str[i] == str[i+1])
  		{
  			isUnique=false;
	  		cout<<"There are duplicate characters in the given string \n";
  			break;
		}
	  	else
	  		continue;
  	}
  	if (isUnique==true)
  	cout<<"\n Given string has unique characters";
	if(str.size() == str1.size()) // Checks whether two strings are palindrome of each other
  	{
  		int k=0;
  		for(int j=0; j<str.size();j++)
  		{
  			if(str[j]==str1[k])
  			{
			  	++k;
  				continue;
  			}
			else
			{
				isPalindrome=false;
				cout<<"\n Given strings are not palindrome";
				break;
			}
   		}	 
  	}
	else
   	{
   		isPalindrome=false;
		cout<<"\n Given strings not palindrome";
	}	
  	if(isPalindrome==true)
  		cout<<"\n Given string is a palindrome";
  	for(int k=str.size() + 3; k>0; k++)
  	{
  		if(str[k] == ' ')
  		{
  			
		}
	}
  	return 0;
}
