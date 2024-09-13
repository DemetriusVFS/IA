int transicao, estado;

Console.WriteLine("Digite o Estado indicando de 1 a 3");
estado = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a Transição indicando 0 ou 1");
transicao = int.Parse(Console.ReadLine());

if (estado == 1 & transicao == 0 | estado == 2 & transicao == 0)
{
    Console.WriteLine("Seu estado atual é: 3");
}
else if (estado == 3 & transicao == 1)
{
    Console.WriteLine("Seu estado atual é: 2");
}
else if (estado == 2 & transicao == 1)
{
    Console.WriteLine("Seu estado atual é: 1");

}