using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;


[ApiController]
[Route("api/in")]

public class InController : Controller {
   [HttpGet("listar-operacion")]

   public IActionResult ListarOperacion(){
    // Muestra todos los registros donde la operación sea "Venta" o "Renta".

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    List<string> operacion = new List<string>();
    operacion.Add("Renta");

    operacion.Add("Venta");

    var filtro = Builders<Inmueble>.Filter.In(x => x.Operacion, operacion);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
   



   [HttpGet("listar-tipo")]

   public IActionResult ListarTipo(){
    // Muestra todos los registros cuyo tipo de inmueble sea "Casa" o  "Departamento".
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

      List<string> tipo = new List<string>();
    tipo.Add("Casa");

    tipo.Add("Departamento");

    var filtro = Builders<Inmueble>.Filter.In(x => x.Tipo, tipo);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
   




   [HttpGet("listar-registros-tipo")]

   public IActionResult ListarRegistrosTipo(){
    // Muestra todos los registros con un baño de propiedad en Terreno y Casa

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

       List<string> tipo = new List<string>();
    tipo.Add("Terreno");

    tipo.Add("Casa");

    var filtro = Builders<Inmueble>.Filter.In(x => x.Tipo, tipo);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);


    }
    
    [HttpGet("listar-baños")]

   public IActionResult ListarBaños(){
    // Muestra todos los registros con al menos 2 o 3 baños.

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

     List<int> banios = new List<int>();
    banios.Add( 2 );

    banios.Add( 3 );


    var filtro = Builders<Inmueble>.Filter.In(x => x.Banios, banios);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }


 [HttpGet("listar-numero-pisos")]

   public IActionResult ListarNumeroPisos(){
    // Muestra todos los registros donde el número de pisos sea 1, 2 o 3.

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    List<int> numero = new List<int>();
    numero.Add(1);

    numero.Add(2);

    var filtro = Builders<Inmueble>.Filter.In(x => x.Pisos, numero);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
   

}