﻿using Microsoft.AspNetCore.Mvc;
using RestApiModeloTdd.Aplication.Dtos;
using RestApiModeloTdd.Aplication.Interfaces;
using System;
using System.Collections.Generic;

namespace RestApiModeloTdd.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IApplicationServiceCliente applicationServiceCliente;

        public ClientesController(IApplicationServiceCliente applicationServiceCliente)
        {
            this.applicationServiceCliente = applicationServiceCliente;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceCliente.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceCliente.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ClienteDTO clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                applicationServiceCliente.Add(clienteDTO);
                return Ok("Cliente Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ClienteDTO clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                applicationServiceCliente.Update(clienteDTO);
                return Ok("Cliente Atualizado com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ClienteDTO clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                applicationServiceCliente.Remove(clienteDTO);
                return Ok("Cliente Removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}