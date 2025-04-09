using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;


[ApiController]
[Route("api/nin")]

public class NinController : Controller {
   [HttpGet("listar-costo")]

   public IActionResult ListarCosto(){
    // Muestra todos los registros cuyo costo no esté en 500000, 750000, 1000000

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

     List<int> costo = new List<int>();
    costo.Add(500000);

    costo.Add(750000);

    costo.Add(1000000);

    var filtro = Builders<Inmueble>.Filter.Nin(x => x.Costo, costo);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
   



   [HttpGet("listar-pisos")]

   public IActionResult ListarPisos(){
    //Muestra todos los registros con número de pisos no incluido en 1, 2

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

     List<int> pisos = new List<int>();
    pisos.Add(1);

    pisos.Add(2);

    var filtro = Builders<Inmueble>.Filter.Nin(x => x.Pisos, pisos);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
   




   [HttpGet("listar-agencia")]

   public IActionResult ListarAgencia(){
    //Muestra todos los registros cuya agencia no esté entre "Vivienda Express", "Hogar Ideal".

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    List<string> agencia = new List<string>();
    agencia.Add("Vivienda Express");

    agencia.Add("Hogar Ideal");


    var filtro = Builders<Inmueble>.Filter.Nin(x => x.Agencia, agencia);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);


    }
    
    [HttpGet("listar-baños")]

   public IActionResult ListarBaños(){
    // Muestra todos los registros con cantidad de baños no incluida en 1, 2, 3.

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    List<int> banios = new List<int>();
    banios.Add(1);

    banios.Add(2);

    banios.Add(3);

    var filtro = Builders<Inmueble>.Filter.Nin(x => x.Banios, banios);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }

[HttpGet("listar-registros-ventas")]

   public IActionResult ListarRegistrosVentas(){
    // Muestra todos los registros cuya operación no sea ni "Venta" ni "renta"

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

     List<string> operacion = new List<string>();
    operacion.Add("venta");

    operacion.Add("renta");

    var filtro = Builders<Inmueble>.Filter.Nin(x => x.Operacion, operacion);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
   


}