using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using RBC_oficial.Data;
using RBC_oficial.Models;

namespace RBC_oficial.Repositorio;

    public class CasoRepositorio : ICasoRepositorio
    {

        private readonly BancoContext _bancoContext;
        public CasoRepositorio(BancoContext bancoContext)
        {
           _bancoContext = bancoContext;
        }

      public List<CasoModel> BuscarTodos()
      {
         return _bancoContext.Casos.ToList();
      }
       public CasoModel Adicionar(CasoModel caso)
       {
            //gravar no banco

            

            _bancoContext.Casos.Add(caso);
            _bancoContext.SaveChanges();
            return caso;
       }
        

    }