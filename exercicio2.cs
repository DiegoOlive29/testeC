using System;

    
class exercicio2{ 

    static void Main (){ 
        Console.Write("Digite a sequência numerica: ");

        string sequencia = (Console.ReadLine());      
        
        string numSemRepetir="";
        
        for(int i = 0 ; i < sequencia.Length  ; i++ ){

            char num = sequencia[i];
            bool teste = false;
            for(int a = 0 ; a <= numSemRepetir.Length-1 ; a++){
                if(num == numSemRepetir[a]){
                teste = true;
                }
            }
            if (!teste){
                numSemRepetir = numSemRepetir + num;
            }
        }
              
        int[,] tabela = new int [2,numSemRepetir.Length];

        for(int i = 0 ; i < numSemRepetir.Length; i++){
            tabela[0,i]=(int)numSemRepetir[i];
            tabela[1,i]=0; 
            
        }
        
        for(int i = 0 ; i <sequencia.Length ; i++){
            char num = sequencia[i];
             for(int a = 0 ; a < numSemRepetir.Length ; a++){
                if(num == tabela[0,a]){
                tabela[1,a] = tabela[1,a]+ 1 ;
                }
            }

        }
        
        int result = 0;
        int maior = 0;
        
        for(int i = 0 ; i < numSemRepetir.Length; i++){
            if(maior < tabela[1,i]){  
               
                maior = tabela[1,i];
                result = tabela[0,i] ;
            };
            
        }
        Console.Write((char)result);

      
    }
    
}
// Exercício 2
// // Fazer um programa em c#, java ou em liguagem de algoritmo que dado uma 
// sequência numerica, exiba o número que apareceu mais vezes.
// // Se dois números aparecerem com a mesma quantidade exibir 
// o que apareceu pela primeira vez por ultimo

// Exemplo 1:
// Entrada: 245431234
// Saída: 4

// Example 2:
// Entrada: 123765423754838338788
// Sáida: 3