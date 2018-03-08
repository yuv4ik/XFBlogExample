using System.Collections.Generic;
using System.Linq;
using BlogAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPI.Controllers
{
    [Route("api/[controller]")]
    public class BlogController : Controller
    {

        static List<BlogPost> dataSource = new List<BlogPost>();

        [HttpPost]
        [ProducesResponseType(typeof(BlogPost), 201)]
        [ProducesResponseType(typeof(BlogPost), 400)]
        public IActionResult Add([FromBody]BlogPost post)
        {
            post.Id = dataSource.Count + 1;
            dataSource.Add(post);
            return Created($"/blog/{post.Id}", post);
        }

        [HttpGet("{id:int}", Name = "GetBlogPostById")]
        [ProducesResponseType(typeof(BlogPost), 200)]
        [ProducesResponseType(typeof(BlogPost), 404)]
        public IActionResult Get(int id)
        {
            var blogPost = dataSource.ElementAtOrDefault(id - 1);
            if (blogPost == null)
                return NotFound();

            return Ok(blogPost);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<BlogPost>), 200)]
        public IActionResult List() => Ok(dataSource);
    }
}
