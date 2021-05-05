using Ecommerce.Data;
using Ecommerce.Personal;
using System;
using System.Collections.Generic;
using System.Linq;

public class UserDAO
{
    private BDEcommerce contexto;

    public UserDAO(BDEcommerce contexto)
    {
        this.contexto = contexto;
    }
    
    public User Busca(string login, string password) // pergunta rogério - estas strings deveriam ter o mesmo nome que as strings da classe user ???
    {
        return contexto.Users.Where(user => user.LoginUser.Equals(login) && user.PassUser.Equals(password)).FirstOrDefault<User>();
    }

    public static int InsertUser(List<User> l) //C - R - U - D
    {
        int result = 0;
        using (var db = new BDEcommerce())
        {
            db.Users.AddRange(l);
            result = db.SaveChanges();
        }
        return result;
    }
}
