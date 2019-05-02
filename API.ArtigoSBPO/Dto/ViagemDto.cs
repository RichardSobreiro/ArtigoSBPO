using System;

namespace API.ArtigoSBPO.Dto
{
    public class ViagemDto
    {
        public int viagemId { get; set; }
        public string clienteDescricao { get; set; }
        public string inicio { get; set; }
        public string fim { get; set; }
        public string horarioSolicitado { get; set; }
        public string horarioReal { get; set; }
        public string horarioRealFinalPesagem { get; set; }
        public string horarioOtimoFinalPesagem { get; set; }
        public string atrasoPesagem { get; set; }
        public string avancoPesagem { get; set; }
        public string atrasoChegadaCliente { get; set; }
        public string avancoChegadaCliente { get; set; }
    }
}
