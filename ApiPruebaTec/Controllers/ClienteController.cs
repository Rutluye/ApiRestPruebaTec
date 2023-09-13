using ApiPruebaTec.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiPruebaTec.Controllers
{
    [ApiController]
    [Route("cliente")]

    public class ClienteController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public dynamic ListarCliente()
        {

            List<Cliente> cliente = new List<Cliente>
            {

            new Cliente
            {
                id = 1,
                nombre = "Rut Luye",
                edad = 30,
                correo = "rutluye@gmail.com"

            },
            new Cliente
            {

                id = 2,
                nombre = "Ariana Luye",
                edad = 20,
                correo = "rutluye@gmail.com"

            }
            };


            return cliente;

        }
        [HttpPost]
        [Route("guardar")]

        public dynamic GuardarCliente(Cliente cliente) 
        
        { 

            cliente.id = 1;

            return new
            {

                success = true,
                message = "Cliente registrado",
                result = cliente

            };
        
        }



    }
    }
