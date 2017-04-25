#include <stdio.h>
#include <conio.h>

int main()
{
	printf("Enter character ");
	char input;
	scanf("%c", &input);
    if ((input - 'a'>= 18))
    {
    	int reduce = ((input - 'a') == 25) ? 2 : 1;
    	input-= reduce;
	}
	int digit = (input - 'a') / 3;
	digit += 2;
    
	printf("\nDigit in telepad is %d", digit);
	getch();
}
