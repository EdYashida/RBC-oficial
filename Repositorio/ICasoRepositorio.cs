using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using RBC_oficial.Models;

namespace RBC_oficial.Repositorio;

    public interface ICasoRepositorio
    {
        List <CasoModel> BuscarTodos();
        CasoModel Adicionar(CasoModel caso);
        

    }

