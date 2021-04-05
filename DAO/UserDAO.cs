using System;

public class UserDAO
{
    private EcommerceContext contexto;

    public UserDAO(EcommerceContext contexto)
    {
        this.contexto = contexto;
    }
    
    public User Busca(string login, string password)
    {
        return contexto.Users
                    .Where(user => user.Nome.Equals(login) && user.Senha.Equals(password))
                    .FirstOrDefault<Usuario>();
    }

    public void Adiciona(User user)
    {
        contexto.Users.Add(user);
        contexto.SaveChanges();
    }
}
