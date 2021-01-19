using System;
using System.Collections.Generic;
using System.Text;

namespace EstudosOO.Models
{
    public class Veiculo
    {
        public string Placa { set; get; }
        public float Roda { set; get; }
        public float Porta { set; get; }
        

        public Veiculo(string placa, float roda, float porta)
        {
            Placa = placa;
            Roda = roda;
            Porta = porta;
        }

        public Veiculo()
        {
        }

        public override string ToString()
        {
            return Placa + "-" + Roda + "-" + Porta;
        }
    }
}
