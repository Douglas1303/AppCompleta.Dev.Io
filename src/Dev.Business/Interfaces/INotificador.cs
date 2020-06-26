﻿using Dev.Business.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dev.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao); 
    }
}