using System;

namespace API.ArtigoSBPO.Dto
{
    public class ViagemDto
    {
        public int viagemId { get; set; }
        public DateTime inicio { get; set; }
        public DateTime fim { get; set; }
        public string clienteDescricao { get; set; }
    }
}
