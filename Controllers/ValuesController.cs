using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTAPI_ajl.Controllers
{
	public class ValuesController : ApiController
	{
		// GET api/values
		public IEnumerable<string> Get()
		{
			return new string[] { "Adolfo Javier Lòpez", "2956352014" };
		}

		// GET api/values/5
		public string Get(int id)
		{
			return "value";
		}

		// POST api/values
		public void Post([FromBody] string value)
		{
		}

		// PUT api/values/5
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/values/5
		public void Delete(int id)
		{
		}
	}
}
