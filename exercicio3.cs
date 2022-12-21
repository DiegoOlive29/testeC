using System;

public class Pedido{

    public string lanche;
    public string salada;
    public int qtdbatata;
    public string maioneseLanche; 
    public string maioneseBatata;
    public int refrigerante;
    public int qtdLanches;
    public int total;


}
    
class exercicio3{ 

    static void Main (){ 
        Console.Clear();
    
            Pedido p = new Pedido();
          
            Console.Write("Quantos lanches?");
            p.qtdLanches =int.Parse(Console.ReadLine());
           
           for(int i = 1 ; i <= p.qtdLanches ;i++){

                inicio:
                Console.Write("Qual o sabor do lanche "+ i +" de carne ou frango?\n");

                p.lanche = Console.ReadLine();

                if((p.lanche == "carne") ||(p.lanche =="Carne")){

                    p.total = p.total + 20;

                }else if((p.lanche == "Frango") || (p.lanche =="frango")){

                    p.total = p.total + 16;

                }else{

                    Console.Write("\n Escolha o sabor Frango ou Carne. \n\n");

                    goto inicio;
                }

                saladaVolta:

                Console.Write("Gostaria de salada junto ao lanche? Sim ou Não.\n");

                    p.salada = Console.ReadLine();

                if((p.salada == "Sim") ||(p.salada =="sim")){

                    p.total = p.total + 2;
                    
                }else if((p.salada == "não") || (p.salada =="não")){

                }else{

                    Console.Write("\n Digite sim ou não para dizer se quer salada junto ao lanche. \n\n");
                    
                    goto saladaVolta;
                }

                maioneseVolta:

                Console.Write("Gostaria de maionese junto ao lanche? Sim ou Não.\n");

                p.maioneseLanche = Console.ReadLine(); 

                if((p.maioneseLanche == "Sim") ||(p.maioneseLanche =="sim")){

                    p.total = p.total + 1;

                }else if((p.maioneseLanche == "não") || (p.maioneseLanche =="não")){

                }else{

                    Console.Write("\n Digite sim ou não para dizer se quer maionese junto ao lanche. \n\n");
                    
                    goto maioneseVolta;
                }

                Console.Clear();

           }
            

            Console.Write("Quantas batatas?\n");
            p.qtdbatata = int.Parse(Console.ReadLine());

            p.total = p.total + (p.qtdbatata * 6);

            for(int i = 1 ; i <= p.qtdbatata ;i++){
                inicio:

                Console.Write("Gostaria de maionese junto a batata "+ i +"? Sim ou Não.\n");
                p.maioneseBatata = Console.ReadLine();
                
                if((p.maioneseBatata == "Sim") ||(p.maioneseBatata =="sim")){

                    p.total = p.total + 1;

                }else if((p.maioneseBatata == "não") || (p.maioneseBatata =="não")){

                }else{

                    Console.Write("\n Escolha o sabor sim ou não. \n\n");

                    goto inicio;
                }

                

            }
            
            
            
            Console.Write("Quantos refrigerantes?");
            p.refrigerante =int.Parse(Console.ReadLine());

            p.total = p.total + (p.refrigerante * 4 );

           
            Console.Write(p.total);
    }
    
}
// Exercício 3

// Fazer um programa em c#, java ou em liguagem de algoritmo para:
// Uma lanchonete possui os seguintes produtos lanche de carne (R$20) ou de frango (R$16),
// batata frita (R$6) e refrigerante (R$4).
// Os lanches podem ou não vir com salada. Acréscimo de R$2
// Os lanches e a batata podem ou não vir com maionese. Acréscimo de R$1
// Desenhar as classes e criar uma função para verificar o preço do pedido

// Exemplo 1:
// Entrada: 1 hamburguer de carne com salada e 2 refrigerantes 
// Saída: 30 

// Example 2:
// Entrada: 2 hamburguer de carne sem salada, 2 batatas fritas com maionese e 1 refrigerante
// Sáida: 58