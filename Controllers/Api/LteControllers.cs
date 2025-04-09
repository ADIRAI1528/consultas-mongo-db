using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;


[ApiController]
[Route("api/lte")]

public class LteController : Controller {
   [HttpGet("listar-baños")]

   public IActionResult ListarBaños(){
    // Muestra todos los registros donde el número de baños sea 2 o menos.

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lte(x => x.Banios, 2);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
   



   [HttpGet("listar-pisos")]

   public IActionResult ListarPisos(){
    //Muestra todos los registros cuyo pisos sea 10 o menos.
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lte(x => x.Pisos, 10);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
   




   [HttpGet("metros-terreno")]

   public IActionResult MetrosTerreno(){
    //Muestra todos los registros donde el terreno sea de 200 o menos.
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lte(x => x.MetrosTerreno, 200);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);


    }
    
    [HttpGet("listar-costo")]

   public IActionResult ListarCosto(){
    // Muestra todos los registros donde el costo de venta sea menor o igual a 800,000.

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lte(x => x.Costo, 8000000);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }

[HttpGet("listar-registros-menos")]

   public IActionResult ListarRegistrosMenos(){
    // Muestra todos los registros donde el metros terreno sea de 200m o menos.

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lte(x => x.MetrosTerreno, 200);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }

}