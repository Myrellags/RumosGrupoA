using Ecommerce.Data;
using Ecommerce.Personal;
using System;
using System.Linq;

public class UserDAO
{
    private BDEcommerce contexto;

    public UserDAO(BDEcommerce contexto)
    {
        this.contexto = contexto;
    }
    
    public User Busca(string login, string password)
    {
        return contexto.Users.Where(user => user.LoginUser.Equals(login) && user.PassUser.Equals(password)).FirstOrDefault<User>();
    }

    public void Adiciona(User user)
    {
        contexto.Users.Add(user);
        contexto.SaveChanges();
    }
}
