using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace recordetur_api.Models
{
    public class Viagens
    {
        [Key]
        
        public int ViagemId { get; set; }

        public string Descricao { get; set; }
        public string Destino { get; set; }

        public double Preco { get; set; }

        [JsonIgnore]
        public List<Reservas> Reservas { get; set; }

    }
}
