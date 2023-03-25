double n1,n2;

Console.Write("Digite um número: ");
n1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite outro  número: ");
n2 = Convert.ToDouble(Console.ReadLine());

double raiz = Math.Sqrt(n1);
double potencia = Math.Pow(n1,n2);

Console.WriteLine($"A raiz quadrada de {n1} é {raiz}.");

Console.WriteLine($"O número {n1} elevado a {n2} a potência é {potencia}.");

