#include<iostream>
using namespace std;
void reverseStr(string &str)
{
    int n = str.length();
 
    // Swap character starting from two
    // corners
    for (int i=0; i<n/2; i++)
       swap(str[i], str[n-i-1]);
}

int main()
{
   string str; 
   cout<<"Enter the string:";
   cin>>str;
   reverseStr(str);
   cout << str;
   return 0;
}


 
// Function to reverse a string

