using Newtonsoft.Json;

namespace API.ArtigoSBPO.DataObjects
{
    [JsonObject]
    public class ViagemInfo
    {
        [JsonProperty("Viagem")]
        public int Viagem { get; set; }
        [JsonProperty("Inicio")]
        public int Inicio { get; set; }
        [JsonProperty("Fim")]
        public int Fim { get; set; }
        [JsonProperty("HorarioSolicitado")]
        public int HorarioSolicitado { get; set; }
        [JsonProperty("HorarioReal")]
        public int HorarioReal { get; set; }
        [JsonProperty("HorarioRealFinalPesagem")]
        public int HorarioRealFinalPesagem { get; set; }
        [JsonProperty("HorarioOtimoFinalPesagem")]
        public int HorarioOtimoFinalPesagem { get; set; }
        [JsonProperty("AtrasoPesagem")]
        public int AtrasoPesagem { get; set; }
        [JsonProperty("AvancoPesagem")]
        public int AvancoPesagem { get; set; }
        [JsonProperty("AtrasoChegadaCliente")]
        public int AtrasoChegadaCliente { get; set; }
        [JsonProperty("AvancoChegadaCliente")]
        public int AvancoChegadaCliente { get; set; }
    }
}
