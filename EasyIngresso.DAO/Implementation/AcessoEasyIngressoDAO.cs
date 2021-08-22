using System;
using System.Linq;
using System.Collections.Generic;
using EasyIngresso.TO;
using EasyIngresso.DAO.Entity;

namespace EasyIngresso.DAO.Implementation
{
    public class AcessoEasyIngressoDAO : SuperDAO<AcessoEasyIngresso>, IAcessoEasyIngressoDAO
    {
        public void Alterar(AcessoEasyIngresso acessoEI)
        {
            using (var context = new ModelDataContext())
            {
                var acesso = (from b in context.AcessoEasyIngressos
                              where b.codPessoa == acessoEI.codPessoa
                              select b).SingleOrDefault();
                if (acesso != null)
                {
                    acesso.codPessoa = acessoEI.codPessoa;
                    acesso.nmPessoa = acessoEI.nmPessoa;
                    acesso.nmLogon = acessoEI.nmLogon;
                    acesso.nmPassword = acessoEI.nmPassword;
                    acesso.nmDataCriacao = acessoEI.nmDataCriacao;
                }
                context.SubmitChanges();
            }
        }



        public int Inserir(AcessoEasyIngresso acessoEI)
        {
            using (var context = new ModelDataContext())
            {
                var acesso = new AcessoEasyIngresso
                {
                    codPessoa = acessoEI.codPessoa,
                    nmDataCriacao = acessoEI.nmDataCriacao,
                    nmLogon = acessoEI.nmLogon,
                    nmPassword = acessoEI.nmPassword,
                    nmPessoa = acessoEI.nmPessoa
                };
                context.AcessoEasyIngressos.InsertOnSubmit(acesso);
                context.SubmitChanges();
                return acesso.codPessoa;
            }
        }

        public List<AcessoEasyIngresso> Listar(int codPessoa)
        {
            using (var context = new ModelDataContext())
            {
                var banco = (from b in context.AcessoEasyIngressos
                             where b.codPessoa == codPessoa
                             select new AcessoEasyIngresso
                             {
                                 codPessoa = b.codPessoa,
                                 nmPessoa = b.nmPessoa,
                                 nmLogon = b.nmLogon,
                                 nmPassword = b.nmPassword,
                                 nmDataCriacao = b.nmDataCriacao
                                
                             }).OrderByDescending(b => b.nmDataCriacao);
                return banco.ToList();
            }
        }
    }
}
