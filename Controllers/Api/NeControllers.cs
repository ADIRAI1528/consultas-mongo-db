using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;


[ApiController]
[Route("api/Ne")]

public class NeController : Controller {
   [HttpGet("listar-costo")]

   public IActionResult ListarCosto(){
    // Muestra todos los registros cuyo costo no sea 1,000,000

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Ne(x => x.Costo, 1000000);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
   



   [HttpGet("listar-pisos")]

   public IActionResult ListarPisos(){
    //Muestra todos los registros cuyo número de pisos no sea 2
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Ne(x => x.Pisos, 2);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
   




   [HttpGet("listar-agencia")]

   public IActionResult ListarAgencia(){
    //Muestra todos los registros cuya agencia no sea "Inmuebles del Norte"

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Ne(x => x.Agencia, "Inmobiliaria Pérez");
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);


    }
    
    [HttpGet("listar-baños")]

   public IActionResult ListarBanios(){
    // Muestra todos los registros que no tengan 3 baños

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Ne(x => x.Banios, 3);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }


[HttpGet("listar-registros-agencia")]

   public IActionResult ListarRegistrosAgencia(){
    // Muestra todos los registros cuya agencia no sea Fernández Inmuebles

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Ne(x => x.Agencia, "fernández inmuebles");
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
   
}