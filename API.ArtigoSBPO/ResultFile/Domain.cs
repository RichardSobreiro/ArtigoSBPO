using API.ArtigoSBPO.DataObjects;
using API.ArtigoSBPO.Dto;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace API.ArtigoSBPO.ResultFile
{
    public static class Domain
    {
        public static List<BetoneiraDto> GetConcreteMixerTimeline()
        {
            Viagens viagens = ReadJson();
            Dictionary<int, BetoneiraDto> betoneirasDictionary = new Dictionary<int, BetoneiraDto>();

            foreach(ViagemInfo viagemInfo in viagens.viagens)
            {
                if(!betoneirasDictionary.ContainsKey(viagemInfo.Betoneira))
                {
                    betoneirasDictionary.Add(viagemInfo.Betoneira, new BetoneiraDto());
                    betoneirasDictionary[viagemInfo.Betoneira].viagens = new List<ViagemDto>();
                    betoneirasDictionary[viagemInfo.Betoneira].pontoCargaId = viagemInfo.PontoCarga;
                }
                ViagemDto viagemDto = ConverterViagemInfoParaViagemDto(viagemInfo);
                betoneirasDictionary[viagemInfo.Betoneira].viagens.Add(viagemDto);
            }

            List<BetoneiraDto> betoneiras = new List<BetoneiraDto>();
            for(var i = 0; i < betoneirasDictionary.Count; i++)
            {
                betoneiras.Add(betoneirasDictionary[betoneirasDictionary.Keys.ElementAt(i)]);
            }

            return betoneiras;
        }

        public static Viagens ReadJson()
        {
            Viagens viagens;
            using (StreamReader file = File.OpenText(@"C:\ArtigoSBPO\API.ArtigoSBPO\ResultFile\Result.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject o2 = (JObject)JToken.ReadFrom(reader);
                viagens = o2.ToObject<Viagens>();
            }
            
            return viagens;
        }

        private static ViagemDto ConverterViagemInfoParaViagemDto(ViagemInfo viagemInfo)
        {
            ViagemDto viagemDto = new ViagemDto();
            viagemDto.clienteDescricao = $"Cliente {viagemInfo.Viagem}";
            viagemDto.viagemId = viagemInfo.Viagem;
            viagemDto.inicio = ConverterMinutosParaHoraMinutos(viagemInfo.Inicio);
            viagemDto.fim = ConverterMinutosParaHoraMinutos(viagemInfo.Fim);
            return viagemDto;
        }

        private static DateTime ConverterMinutosParaHoraMinutos(int minutosTotal)
        {
            int horas = (minutosTotal - (minutosTotal % 60)) / 60;
            int minutos = minutosTotal - (horas * 60);
            DateTime dataAtual = DateTime.Now;
            return new DateTime(dataAtual.Year, dataAtual.Month, dataAtual.Day, 0, 0, 0)
                .AddHours(horas).AddMinutes(minutos);
        }
    }
}
