using System;

    
class exercicio1{ 

    static void Main (){ 
       
            double dolar,valor,reais; 

            dolar= 5.36;
          

            Console.Write("Digite o valor a ser convertido: ");
            valor = double.Parse(Console.ReadLine());

            reais =  valor * dolar;
            
            Console.WriteLine("O resultado da conversão é {0,5:c}",reais);
            

       
    }
    
}
// Exercício 1
// Sabendo que hoje o 1 dolar é equivalente a 5,36 reais.
// Fazer um programa em c#, java ou em liguagem de algoritmo que dado um valor em dolar, exiba o equivalente em reais

// Exemplo 1:
// Entrada: 10
// Saída: 53,60

// Example 2:
// Entrada: 58
// Sáida: 310,88 