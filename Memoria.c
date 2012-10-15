#include <stdio.h>

#define TEXTO1  "¿ Hola , como "

#define TEXTO2  "le va a Ud. ? "

int main(void)
{

	char palabra[8] , *p ; // cambio en el tamano del arreglo de 15 a 8
	int i ;
	
	p = TEXTO1 ;

	for( i = 0 ; ( palabra[i] = *p++ ) != '\0' ; i++ );

	p = TEXTO2 ;

	printf("%s \n" , palabra ) ;
	printf("%s" , p ) ;

	return 0 ;
}
