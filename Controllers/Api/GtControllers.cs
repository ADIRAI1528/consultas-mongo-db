using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;


[ApiController]
[Route("api/gt")]

public class GtController : Controller {
   [HttpGet("listar-costo")]

   public IActionResult ListarCosto(){
    // Muestra todos los registros donde el costo de venta sea mayor a 1,000,000.

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gt(x => x.Costo, 1000000);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
   



   [HttpGet("listar-pisos")]

   public IActionResult ListarPisos(){
    // Muestra todos los registros donde el número de habitaciones sea mayor a 3.

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gt(x => x.Pisos, 3);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
   




   [HttpGet("metros-terreno")]

   public IActionResult MetrosTerreno(){
    // Muestra todos los registros donde el número de metros terreno sea mayor a 200.

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gt(x => x.MetrosTerreno, 200);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);


    }
    
    [HttpGet("listar-baños")]

   public IActionResult ListarBañosbaños(){
    // Muestra todos los registros donde el número de baños sea mayor a 2.

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gt(x => x.Banios, 2);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }

}