using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace WebApplication1.Controllers
{
	public class PublishController : ApiController
	{

		[HttpPost]
		[Route("api/profile/{profileId}/publish")]
		public IHttpActionResult PostPublish([FromBody] PublishOptions options, int profileId, [FromUri] string publishers = null)
		{
			if (options == null) options = new PublishOptions(); //guard against null

			if (options.PublishConfig != null)
			{
				var x = 1; //never gets here, PublishConfig always null
			}


			return Ok();
		}

	}

	public class PublishOptions
	{
		public bool WaitForAll { get; set; }
		public Newtonsoft.Json.Linq.JToken PublishConfig { get; set; }
	}
}