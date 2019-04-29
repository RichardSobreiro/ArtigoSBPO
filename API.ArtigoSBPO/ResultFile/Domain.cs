using API.ArtigoSBPO.DataObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace API.ArtigoSBPO.ResultFile
{
    public static class Domain
    {
        public static void GetConcreteMixerTimeline()
        {
            Viagens viagens = ReadJsonInto();


        }

        public static Viagens ReadJsonInto()
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
    }
}
