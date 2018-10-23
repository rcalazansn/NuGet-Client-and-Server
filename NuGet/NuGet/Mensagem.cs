using System;

namespace NuGet
{
    public static class Mensagem
    {
        public static void MensagemConsole(string mensagem)
        {
            if (string.IsNullOrEmpty(mensagem))
                Console.WriteLine("Necessário informar uma mensagem");
            else
                Console.WriteLine(mensagem);
        }
    }
}
