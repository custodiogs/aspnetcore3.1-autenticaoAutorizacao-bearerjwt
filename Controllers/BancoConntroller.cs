using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Banco{
    [Route("v1/banco")]
    public class BancoConntroller : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody]User model){
            var user = UserRepository.Get(model.Username, model.Password);

            if(user == null)
                return NotFound(new {message = "Usuário inválido"});

            var token = TokenService.GenerateToken(user);
            user.Password = "";
            return new {
                user = user,
                token= token
            };
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous()=>"Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated()=>string.Format("Autenticado - {0}", User.Identity.Name);

        [HttpGet]
        [Route("meuperfil")]
        [Authorize(Roles="Caixa,Gerente de Relacionamento")]
        public string MeuPerfil()=>string.Format("MeuPerfil");

        [HttpGet]
        [Route("gerenciar")]
        [Authorize(Roles="Gerente de Relacionamento")]
        public string Gerenciar()=>string.Format("Página do gerente");
    }
}