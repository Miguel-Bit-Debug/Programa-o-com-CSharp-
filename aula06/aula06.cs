using System;

class Aula06 {

    static void Main() {

        int n1, n2, n3;

        n1 = 10;
        n2 = 20;
        n3 = 30;

        double valorCompra = 5.5;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra + (valorCompra*lucro);

        Console.WriteLine("Produto........:{0,15}", produto);
        Console.WriteLine("Val. Compra .....:{0,15:c}", valorCompra);
        Console.WriteLine("Lucro.....: {0,15:p}", lucro);
        Console.WriteLine("Val. Venda .....:{0,15:c}", valorVenda);



        // Console.WriteLine("n1 \t= \t{0} \nn2 \t= \t{1} \nn3 \t= \t{2}",n1, n2, n3);

    }
}