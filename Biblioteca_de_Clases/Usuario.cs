using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;// pasa lo del Servidor (mongo)
using MongoDB.Bson;

namespace Biblioteca_de_Clases
{
    public class Usuario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
         public string? Id { get; set; }
        [BsonElement("idUsuario")]
        public string? IdUsuario { get; set; }
        [BsonElement("Nombre")]
        public string? Nombre { get; set; }
        [BsonElement("Nombre_usuario")]
        public string? N_Usuario { get; set; }
        [BsonElement("Contrasena")]
        public string? Contrasena { get; set; }
        [BsonElement("Administrador")]
        public  bool? Administrador { get; set; }

    }
}
