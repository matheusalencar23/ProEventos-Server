using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _eventos = new Evento[]
        {
            new Evento(){
                EventoId = 1,
                Tema = "Angular",
                Local = "Fortaleza",
                Lote = "1º lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = ""
            },
            new Evento(){
                EventoId = 2,
                Tema = "Dotnet",
                Local = "Rio de Janeiro",
                Lote = "1º lote",
                QtdPessoas = 500,
                DataEvento = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"),
                ImagemURL = ""
            },
        };

        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> GetAll()
        {
            return _eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _eventos.Where(evento => evento.EventoId == id);
        }
    }
}
