#include<iostream>
#include<cstdio>
#include<cstdlib>
using namespace std;
class LinkedList
{
struct Node
   {
		int value;
		struct Node *next;
		
	};
public :
	 LinkedList()
	 {
	 	head=NULL;
	 }

void Insertion(int x)
{
	Node *temp = new Node();
	temp->value=x;
	temp->next=head;
	head=temp;
	cout<<"\n"<<head->value<<"added as head";
}

void InsertionAtEnd(int x)
{
	Node *temp=head;
	while(temp->next != NULL)
	temp=temp->next;
	Node *newNode=new Node();
	newNode->value=x;
	newNode->next=NULL;
	temp->next=newNode;
	cout<<"\n"<<newNode->value<<"added at end";
}
void PrintLinkList()
{
	cout<<"\n Printing link list\n";
	Node *temp = head;
	while (temp != NULL)
	{
		
		cout<<" "<<temp->value;
		temp = temp->next;
	}
	
}

void DeleteNode()
{
	Node *delete_node=head;
	head=head->next;
	cout<<"\n"<<delete_node->value<<"\t value is deleted";
	delete delete_node;
}
void ReverseList()
{
	Node *temp=NULL, *c;
	while(head != NULL)
	{
		c=head;
		head=head->next;
		c->next=temp;
		temp=c;
	}
	head=temp;
}
void Recursive_Reverse()
{
	if (head != NULL)
	{
		RecursiveWorker(NULL, head);
	}
}

void FindKthElement(int k)
{
	Node *temp=head;
	for(int i=0; i<k; i++)
		temp=temp->next;
	cout<<"\n The element in the given position is "<<temp->value;
}
private:
    Node *head;
    void RecursiveWorker(Node *prev, Node *current)
    {
    	if(current->next == NULL)
    	{
    		head=current;
    		head->next=prev;
    		return;
		}
		else
		{
			RecursiveWorker(current, current->next);
			current->next=prev;	
		}
	}

};

int main()
{
	LinkedList n;
	
    int insert_value,op=1,node_count=0,k;
	cout<<"Linked List";
	
	while(op)
	{
		cout<<"\n 1.Insertion at beginning \n 2.Insertion at end \n 3.Print List \n"; 
		cout<<" 4.Delete Node \n 5.Reverse Iteratively \n 6.Reverse recursively \n ";
		cout<<"7.Finding kth element from last \n 0.Exit ";
		cin >> op;
		if(op==0)
		 break;
		if(op==1)
		{
			cout<<"\nEnter the value\n";
			cin>>insert_value;
			n.Insertion(insert_value);
			node_count++;
		}
		if(op==3)
		{
			if(node_count != 0)
			{
				n.PrintLinkList();
				cout<<"\nTotal number of nodes:"<<node_count;
			}
			else
			cout<<"\nNo elements are present in the linked list";
		}
		if(op==2)
		{
			cout<<"\nEnter the value";
			cin>>insert_value;
			n.InsertionAtEnd(insert_value);
			node_count++;
		}
		if(op==4)
		{
			if(node_count!=0)
			{
				n.DeleteNode();
				node_count--;
			}
			else
			cout<<"\n No elements to delete in the list";
		}
		if(op==5)
			n.ReverseList();
		if(op==6)
			n.Recursive_Reverse();
		if(op==7)
		{
			if(node_count>0)
			{
				cout<<"\n Enter the value of K :";
				cin>>k;
				if(k>node_count)
					cout<<"\n Invalid k value...";
				else
					{
						k=node_count-k;
						n.FindKthElement(k);
					}
			}
			else
				cout<<"\n Sorry! List is empty..."; 
		}
	}
	
	return 0;
}

