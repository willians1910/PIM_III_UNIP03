﻿using Camada.DAL.DAO.PessoasDAO;
using Camada.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.DAL
{
    class DAOFactory
    {
        public static FuncionarioDAO CriarFuncionarioDAO()
        {
            return new FuncionarioDAO();
        }

        public static IVeiculo CriarVeiculoDAO()
        {
            return new VeiculoDAO();
        }

        public static IMotorista CriarMotoristaDAO()
        {
            return new MotoristaDAO();
        }

        public static IEmpresa CriarEmpresaDAO()
        {
            return new EmpresaDAO();
        }
    }
}
