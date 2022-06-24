using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodebProject.Models;

namespace TodebProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WebApiController : ControllerBase
    {
        private List<Post> _post = PostData.Get();
        private readonly PostData _postData;

        /// <summary>
        /// Returns list of all posts
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public List<Post> Get()
        {
            return _post.ToList();
        }

        /// <summary>
        /// Returns the post by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet("{id}")]
        public Post Get(int id)
        {
            var post = _post.FirstOrDefault(x => x.Id == id);
            return post;
        }

        /// <summary>
        /// Sends the post by id
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>

        [HttpPost]
        public IActionResult Post([FromBody] Post post)
        {
            if (post == null)
                return BadRequest();

            _post.Add(post);  
            return CreatedAtRoute("Get", new { id = post.Id }, post);
        }

        /// <summary>
        /// Updates the post by id
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Post post,int id)
        {
            return Ok();
        }

        /// <summary>
        /// Deletes the post by id
        /// </summary>
        /// <param name="post"></param>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete("{id}")]
        public IActionResult Delete([FromBody] Post post, int id)
        {
            return Ok();
        }
    }
}
