using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class NotificacaoSMS : Inotificacao
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando notificação por SMS...");
        }
    }
}
