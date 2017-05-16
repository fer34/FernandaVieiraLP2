#include <stdio.h>

int main(void)
{
	char letra;
	int i, comp, total =0;


	scanf("%d%*c",&comp);

	for (i = 0; i < comp; i++)
	{
		scanf("%c",&letra);

          if(letra == 'P')
          {
          	total = total + 2;
          }

          else if(letra == 'C')
          {
          	total = total + 2;
          }

          else if(letra == 'A')
          {
          	total = total + 1;
          }

          else
          {
          	total = total + 0;
          }
          
	}

	printf("%d", total);
		
		return 0;




}