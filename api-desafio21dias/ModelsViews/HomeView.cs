using System;
using System.Collections.Generic;
using System.IO;

namespace api_desafio21dias.ModelsViews
{
    public record HomeView
    {
        public string Informacao => "Bem vindo!";

        public List<dynamic> Endpoints => new List<dynamic>() {
            new {
             Documentacao = "/swagger" },            
            new { 
                Itens = new List<dynamic>() { 
                    new { Path = "/alunos" },
                    new { Path = "/fornecedores"}
                },
              
            }
        };
    }
}
