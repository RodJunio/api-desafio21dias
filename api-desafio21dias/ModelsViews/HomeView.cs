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
               Item = new { Documentacao = "/swagger" },
            },
            new { 
                Item = new { Path = "/alunos" }
            }
        };
    }
}
