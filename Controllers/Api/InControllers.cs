using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;


[ApiController]
[Route("api/in")]

public class InController : Controller {
   [HttpGet("listar-operacion")]

   public IActionResult ListarCosto(){
    // Muestra todos los registros donde la operación sea "Venta" o "Renta".

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    List<string> operaciones = new List<string>();
    operaciones.Add("Renta");

    operaciones.Add("Venta");

    var filtro = Builders<Inmueble>.Filter.In(x => x.Operacion, operaciones);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
   



   [HttpGet("listar-tipo")]

   public IActionResult ListarNumero(){
    // Muestra todos los registros cuyo tipo de inmueble sea "Casa" o  "Departamento".
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

      List<string> operaciones = new List<string>();
    tipo.Add("Casa");

    tipo.Add("Departamento");

    var filtro = Builders<Inmueble>.Filter.In(x => x.tipo,Tipo);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }
   




   [HttpGet("listar-agencia")]

   public IActionResult ListarAgencia(){
    // Muestra todos los registros con un baño de propiedad en Terreno y Casa

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

       List<string> operaciones = new List<string>();
    agencia.Add("Terreno");

    agencia.Add("Casa");

    var filtro = Builders<Inmueble>.Filter.In(x => x.agencia, Agencia);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);


    }
    
    [HttpGet("listar-baños")]

   public IActionResult ListarBaños(){
    // Muestra todos los registros con al menos 2 o 3 baños.

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

     List<string> operaciones = new List<string>();
    baños.Add( 2 );

    baños.Add( 3 );


    var filtro = Builders<Inmueble>.Filter.In(x => x.baños,Baños);
    var lista = collection.Find(filtro).ToList();

    return Ok (lista);
    }

}