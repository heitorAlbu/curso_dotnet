using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto1.models
{
    public class PushNotificacao : INotificacao
    {
        public void Enviar()
        {
            Console.WriteLine( "enviou Push notification");
        }
    }
}