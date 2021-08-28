
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IRepository<I>
    {
        List<I> Lista();
        I RetornaPorId(int id);
        void Insere(I entidade);
        void Exclui(int id);
        void Atualiza(int id, I entidade);
        int ProximoId();
    }
}
