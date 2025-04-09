using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;


[ApiController]
[Route("api/lt")]

public class LtController : Controller {
   [HttpGet("listar-costo")]

   public IActionResult ListarCosto(){
    //Muestra todos los registros donde el costo sea menor a 500,000.
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lt(x => x.Costo, 500000);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
   



   [HttpGet("listar-pisos")]

   public IActionResult ListarPisos(){
    // Muestra todos los registros donde el número de pisos sea menor a 3.

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lt(x => x.Pisos, 3);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
   




   [HttpGet("registros-fecha-publicacion")]

   public IActionResult RegistrosFechaPublicacion(){
    // Muestra todos los registros donde la fecha publicacion sea menor a 2 años.

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lt(x => x.FechaPublicacion, "2025-01-30");
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);


    }
    
    [HttpGet("metros_terreno")]

   public IActionResult MetrosTerreno(){
    // Muestra todos los registros donde metros terreno sea menor a 250 metros.

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lt(x => x.MetrosTerreno, 250);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }

[HttpGet("listar-registros-construccion")]

   public IActionResult ListarRegistrosContruccion(){
    //Muestra todos los registros donde metros construccion sea menor a 230 metros.

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lt(x => x.MetrosConstruccion, 230);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
}