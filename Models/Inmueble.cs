using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;


public class Inmueble {
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

    
    public string? Id { get; set;}

    [BsonElement("tipo")]

    public string Tipo { get; set; } = string.Empty;
    [BsonElement("operacion")]
    
    public string Operacion { get; set; } = string.Empty;
    [BsonElement("nombre_agente")]

    public string NombreAgente { get; set; } = string.Empty;
    [BsonElement("baños")]

    public string Banios { get; set; } = string.Empty;
    [BsonElement("metros_terreno")]

    public string MetrosTerreno { get; set; } = string.Empty;
    [BsonElement("metros_construccion")]

    public string MetrosConstruccion { get; set; } = string.Empty;
    [BsonElement("tiene_patio")]

    public bool TienePatio { get; set; }
    [BsonElement("pisos")]

    public int Pisos { get; set;}
    [BsonElement("agencia")]

    public string Agencia { get; set; } = string.Empty;
    [BsonElement("fecha_publicacion")]

    public string FechaPublicidad { get; set; } = string.Empty;
    [BsonElement("costo")]

    public int Costo { get; set; }


}