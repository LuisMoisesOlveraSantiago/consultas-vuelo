using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[Route("api/vuelo")]

public class VuelosController : ControllerBase{
    [HttpGet("ciudades-origen")]
    public IActionResult CiudadOrigen(){
        var client  = new MongoClient(CadenaConexion.MONGO_DB);
        var db = client.GetDatabase("Aeropuerto");
        var collection = db.GetCollection<Vuelo>("Vuelos");
        
        var lista = collection.Distinct<string>("CiudadOrigen", FilterDefinition<Vuelo>.Empty).ToList();

        return Ok(lista);

    }

    [HttpGet("ciudad-destino")]
    public IActionResult CiudadDestino(){

        return Ok();

    }

    [HttpGet("estatus")]
    public IActionResult ListarEstatus(){

        return Ok();

    }

    [HttpGet("listar-vuelo")]
    public IActionResult ListarVuelo(){

        return Ok();

    }

}