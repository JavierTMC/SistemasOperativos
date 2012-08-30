#include <stdio.h>

int main(void)
{
	printf("El siguiente programa imprime el complemento a dos de numeros de 4 bits \n"); //imprimir en consola
	
	int contador = 9;
	
	while (contador != -1) //mientras el contador sea diferente de -1, ejecuta
	{
		// unsigned indicamos al compilador que solo usara valores positivos o 0
		unsigned int n = contador; //asignamos contador a n
		int c1 = ~n; 				//obtener complemento a uno
		int c2 = c1 + 1;			//sumar 1 a complemento1
		
		printf("El complemento a dos  de : %d es %d \n", n,c2); //imprimir en consola
		
		contador--; //decrementar el contador (contador)
	}	
	
	int negativo = -1;
	
	while (negativo != -10) //mientras el contador sea diferente de -10, ejecuta
	{
		//signed indicamos al compilador que tomara valores negativos (tambien puede tomar positivos)
		signed int n = negativo; //asignamos contador a n
		int c1 = ~n; 				//obtener complemento a uno
		int c2 = c1 + 1;			//sumar 1 a complemento1
		
		printf("El complemento a dos  de : %d es %d \n", n,c2); //imprimir en consola
		
		negativo--; //decrementar el contador (negativo)
	}	
	

   return 0;
} 
