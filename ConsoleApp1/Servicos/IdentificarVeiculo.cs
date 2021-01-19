using EstudosOO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstudosOO.Servicos
{
    public class IdentificarVeiculo
    {
        public string situacao;

        public string identifica(Veiculo v)
        {
                       
            if (v.Roda > 4)
            {
                situacao = "caminhão";
            }
            else if (v.Roda < 3)
            {
                situacao = "moto";
            }
            else
            {
                situacao = "carro";
            }
            return situacao;
        }
    }


}




