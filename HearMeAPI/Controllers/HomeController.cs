using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HearMeAPI.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private List<TestItem> items = new List<TestItem>
        {
            new TestItem {Id = 1, Content = "value1"},
            new TestItem {Id = 2, Content = "value2"},
            new TestItem {Id = 3, Content = "value3"}
        };
            // GET: api/values
        [HttpGet]
        public IEnumerable<TestItem> GetAll()
        {
            return items;
        }

        // GET api/values/5
        [HttpGet("{id:int}", Name = "GetByIdRoute")]
        public IActionResult Get(int id)
        {
            var item = items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return HttpNotFound();
            }

            return new ObjectResult(item);
        }

        // POST api/values
        [HttpPost]
        public void CreateTestItem([FromBody] TestItem item)
        {
            if (!ModelState.IsValid)
            {
                Context.Response.StatusCode = 400;
            }
            else
            {
                item.Id = 1 + items.Max(x => (int?)x.Id) ?? 0;
                items.Add(item);

                var url = Url.RouteUrl("GetByIdRoute", new { id = item.Id }, Request.Scheme, Request.Host.ToUriComponent());

                Context.Response.StatusCode = 201;
                Context.Response.Headers["Location"] = url;
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult DeleteItem(int id)
        {
            var item = items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return HttpNotFound();
            }

            items.Remove(item);
            return new HttpStatusCodeResult(204); // 201 No Content
        }
    }

    public class TestItem
    {
        public int Id { get; set; }
        public string Content { get; set; }
    }
}
