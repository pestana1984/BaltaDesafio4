internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe o valor da compra: ");
        float total = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor pago: ");
        float pago = float.Parse(Console.ReadLine());
        float troco = pago - total;
        int[] cedulas = { 200, 100, 50, 20, 10, 5, 2 };

        if (troco == 0)
            Console.WriteLine("Sem necessidade de troco");
        else
        {
            Console.WriteLine("O troco deve ser dado no valor de: R$"+troco.ToString("F2"));
            foreach (var cedula in cedulas)
            {
                int qtd = (int)(troco / cedula);
                if (qtd != 0)
                {
                    Console.WriteLine(qtd + " cedulas de R$" + cedula + ",00");
                    troco = troco - (cedula * qtd);
                }
            }
        }
    }
}