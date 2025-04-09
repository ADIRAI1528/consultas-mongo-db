using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;


[ApiController]
[Route("api/eq")]

public class EqController : Controller {
   [HttpGet("listar-operacion")]

   public IActionResult ListarOperacion(){
    // Listar todos los registros cuya operacion sea venta

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Eq(x => x.Operacion, "Venta");
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
   



   [HttpGet("listar-baños")]

   public IActionResult ListarBaños(){
    // Muestra todos los registros que no tienen baños es decir, baños = 0.

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Eq(x => x.Banios, 0);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
   




   [HttpGet("nombre-agente1")]

   public IActionResult NombreAgente1(){
    // Muestra todos los registros de nombreagente

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Eq(x => x.NombreAgente, "María López");
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
   





   [HttpGet("listar-tipo")]

   public IActionResult ListarTipo(){
    // Muestra todos los registros cuyo tipo de propiedad sea "Casa"

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Eq(x => x.Tipo, "Casa");
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }




   [HttpGet("listar-registros-inmuebles")]

   public IActionResult ListarRegistrosInmuebles(){
    // Muestra todos los registros cuyo tipo de inmueble sea "Terreno"

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Eq(x => x.Tipo, "Terreno");
    var lista = collection.Find(filtro).ToList();
    return Ok (lista);
    }
 
}

