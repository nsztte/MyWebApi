﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/Hello")]
    [ApiController]
    public class AbcController : ControllerBase
    {
        // GET: api/<AbcController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "안녕하세요", "반갑습니다" };
        }

        // 라우트 매개변수
        //인라인 제약조건 -> int형으로 라우팅 매개변수 제한
        // GET api/<AbcController>/5
        [HttpGet("{id:int}")]
        public string Get(int id)
        {
            return $"넘어온 값 {id}";
        }

        // POST api/<AbcController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AbcController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AbcController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
