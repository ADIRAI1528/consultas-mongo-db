using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;


[ApiController]
[Route("api/gte")]

public class GteController : Controller {
   [HttpGet("listar-costo")]

   public IActionResult ListarCosto(){
    // Muestra todos los registros donde el costo de renta sea mayor o igual a 15,000.

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gte(x => x.Costo, 15000);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
   



   [HttpGet("listar-baños")]

   public IActionResult ListarBaños(){
    // Muestra todos los registros donde el número de baños sea al menos 2.

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gte(x => x.Banios, 2);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
   




   [HttpGet("metros_terreno")]

   public IActionResult MetrosTerreno(){
    // Muestra todos los registros donde la metros terreno sea de al menos 400.

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gte(x => x.MetrosTerreno, 400);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);


    }
    
    [HttpGet("metros_construccion")]

   public IActionResult MetrosConstruccion(){
    // Muestra todos los registros donde el número de metros construccion sea 500.

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gte(x => x.MetrosConstruccion, 500);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }


 [HttpGet("listar-metros")]

   public IActionResult ListarMetros(){
    // Muestra todos los registros donde el número de metros_terreno sea 4 o más.

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gte(x => x.MetrosTerreno, 4);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }


}