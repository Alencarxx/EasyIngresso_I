using System.Collections.Generic;
using EasyIngresso.TO;
using EasyIngresso.DAO.Entity;

namespace EasyIngresso.DAO
{
    public interface IAcessoEasyIngressoDAO: ISuperDAO<AcessoEasyIngresso>
    {
        int Inserir(AcessoEasyIngresso acessoEI);
        void Alterar(AcessoEasyIngresso acessoEI);        
        List<AcessoEasyIngresso> Listar(int codPessoa);
    }
}

