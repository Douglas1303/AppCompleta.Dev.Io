using Dev.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Dev.AppHard.Controllers
{
    //Controller para fazer tudo que é incomum. E todas as controller devem herdar dela 
    public abstract class BaseController : Controller 
    {
        private readonly INotificador _notificador;

        public BaseController(INotificador notificador)
        {
            _notificador = notificador; 
        }

        protected bool Operacaovalida()
        {
           return !_notificador.TemNotificacao();
        }
    }
}
