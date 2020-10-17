#include <stdio.h> 
#include <string.h> 
#include <stdlib.h> 
  
int main(int argc, char *argv[]) 
{
  
  char buffer[5];
  
  strcpy(buffer, argv[1]);
  
  printf("buffer content= %s\n", buffer);
  printf("strcpy() executed...\n");
  
  return 0;
  
} 
