#include<iostream>
using namespace std;
class Tree
{
	struct Node{
	
		char value;
	    struct Node *lchild;
	    struct Node *rchild;
	};
	
	private:
		Node *root;
	
	public:
	Tree()
	{
		cout<<"\n Root is getting added";
		root = NULL;
		Node *lchild=NULL;
		Node *rchild=NULL;
	}
    void addNode(char value)
	{
		if(root=NULL)
		{
			root->value=value;
			return;
		}	
		else
		{
			Node *temp=new Node();
			if(value < = root->value)
			{
				root=root->lchild;
			}
		}
	}
	void deleteNode(char value)
	{
		
	}
	void searchNode(char value)
	{
		
	}
	void printAll()
	{
	}
};
int main()
{
	char c; int op; bool result;
	Tree t;
	cout<<"\n \t\t Binary Search Tree \t";
	cout<<"\n \t 1.Add an Element \n \t 2.Delete an Element \n \t 3.Search an element \n \t 4.Print all elements";
	cout<<"\n Enter an option:";
	cin>>op;
	switch(op)
	{
		case 1:
			cout<<"\n Enter the element:";
			cin>>c;
			t.addNode(c);
		case 2:
			t.deleteNode(c);
			
		case 3:
			cout<<"\n Enter the element to be searched";
			cin>>c;
			t.searchNode(c);
		case 4:
			t.printAll();
		case 0:
			default:
				break;
	}
	
	return 0;
}
