using System;

    
class exercicio5{ 
    static int EncontreSeq(int n){
        if(n==1){
            return n;
        }
        return 1 + EncontreSeq(n - EncontreSeq(EncontreSeq(n-1)));
        
    }
    static void Main (){ 
        
        int n;
        
        Console.Write("Digite um valor: ");
        n = int.Parse(Console.ReadLine());  
        
        for(int i =1;i<= n ; i++){

            Console.Write(EncontreSeq(i)+", ");

        }

     }
    
}

// Exercício 5
// Criar um programa para mostrar a sequência de Golomb. Dado um valor númerico n de entrada mostre os n primeiros valores da sequencia de Golomb

// Em matemática, a sequência de Golomb, em homenagem a Solomon W. Golomb (mas também chamada sequência de Silverman), é uma sequência não-decrescente de números inteiros, onde a(n) a(n) é o número de vezes em que n ocorre na sequência, começando com a(1)=1, e com a propriedade de que, para n> 1, cada um a(n) é o menor número inteiro que faz com que seja possível satisfazer a condição. Por exemplo, a(1)=1 diz que uma só ocorre o valor 1 uma vez na sequência, de modo que a(2) não pode ser 1 também, e portanto deve ser de 2.
// Os primeiros valores são: 1, 2, 2, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 9, 10, 10, 10, 10, 10, 11, 11, 11, 11, 11, 12, 12, 12, 12, 12, 12 (sequência A001462 na OEIS).

// a(1)=1;a(n+1)=1+a(n+1-a(-a(n)))
// fonte: https://pt.wikipedia.org/wiki/Sequ%C3%AAncia_de_Golomb


// Exemplo 1:
// Entrada: 3
// Saída: 1, 2, 2

// Exemplo 2:
// Entrada: 10
// Saída: 1, 2, 2, 3, 3, 4, 4, 4, 5, 5

// Pode ser feito em c# ou java