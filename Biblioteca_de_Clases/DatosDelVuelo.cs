using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Biblioteca_de_Clases
{
    public class DatosDelVuelo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("Id_Vuelo")]
        public string? IdVUelo { get; set; }
        [BsonElement("Capitan")]
        public string? Capitan { get; set; }
        [BsonElement("Modelo")]
        public string? Modelo { get; set; }
        [BsonElement("Pasajeros")]
        public int Pasajeros { get; set; }
        [BsonElement("Salida")]
        public string? AeropuertoSalida { get; set; }
        [BsonElement("Destino")]
        public string? AeropuertoDestino { get; set; }
    }
}
