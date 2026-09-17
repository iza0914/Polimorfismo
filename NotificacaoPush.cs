using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class NotificacaoPush : Inotificacao
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando notificação push para o app...");
        }
    }
}
