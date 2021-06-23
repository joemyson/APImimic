using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APImimic.Database;
using APImimic.Model;
using Microsoft.AspNetCore.Mvc;

namespace APImimic.Controller
{
    /// <summary>
    /// inicio da injeção de dependecia
    /// </summary>
    /// 

    [Route("api/PalavraModel")] // rotas 
    public class MimicController : ControllerBase // informo a herança controle base
    {
        public readonly MimicDatabase _banco;

        public MimicController( MimicDatabase banco)
        {
            _banco = banco;
        }

        //fim da injeção de dependencia


        //--------------------------------------------
        // inicio do crud

        // metodo obter

        [Route("")]
        [HttpGet]
        public ActionResult ObterTodas()
        {

            return new JsonResult(_banco.Palavras);
        }

        [Route("{id}")]
        [HttpGet]
        public ActionResult ObterPalavra(int id)
        {

            return new JsonResult(_banco.Palavras.Find(id));

        }


        // cadastra

        [Route("")]
        [HttpPost]
        public ActionResult Cadastra([FromBody]PalavraModel palavraModel)
        {

            _banco.Palavras.Add(palavraModel);

            return new JsonResult("ok");
        }

        [Route("{id}")]
        // atualizar
        [HttpPut]
        public ActionResult Atualizar( int id, [FromBody]PalavraModel palavra)
        {

            _banco.Palavras.Update(palavra);

            return new JsonResult("ok");

        }

        // deleta

        [Route("{id}")]
        [HttpDelete]
        public ActionResult Deletar(int id)
        {
            _banco.Palavras.Remove(_banco.Palavras.Find(id));

            return new JsonResult("ok");
        }



    }
}
