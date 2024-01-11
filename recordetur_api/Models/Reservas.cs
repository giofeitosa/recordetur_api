using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace recordetur_api.Models
{
    public class Reservas
    {
        [Key]
       
        public int ReservaId { get; set; }

        public string Data { get; set; }
        public string Valor { get; set; }
        
       
        public int ClienteId { get; set; }
       
        public Clientes Clientes { get; set; }        
        public int ViagemId { get; set; }
        
        public Viagens Viagens { get; set; }
    }
}
