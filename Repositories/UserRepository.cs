using System.Collections.Generic;
using System.Linq;
using Banco;

namespace Banco
{
    public static class UserRepository
    {
        public static User Get(string username,string password)
        {
            var users = new List<User>();
            users.Add(new User{Id=1,Username="JoaoMaria", Password="123456",Role="Caixa"});
            users.Add(new User{Id=1,Username="ThiagoJose", Password="123456",Role="Gerente de Relacionamento"});
            return users.Where(x=>x.Username.ToLower()==username.ToLower() && x.Password.ToLower()==password.ToLower()).FirstOrDefault();
        }
    }
}