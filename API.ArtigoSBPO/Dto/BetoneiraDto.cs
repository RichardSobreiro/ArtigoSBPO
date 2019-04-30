using System.Collections.Generic;

namespace API.ArtigoSBPO.Dto
{
    public class BetoneiraDto
    {
        public List<ViagemDto> viagens { get; set; }
        public int pontoCargaId { get; set; }
    }
}
