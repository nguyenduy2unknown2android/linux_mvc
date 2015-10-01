using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Http;

namespace MyMVC.Controllers
{
	public class WebAPIController : ApiController
	{
		[System.Web.Http.HttpGet]
		public dynamic GetString(string id)
		{
			dynamic result = new {
				ResponseMessage = string.Format("{0} {1}",id,"Mama"),
				StatusCode = true
			};
			return result;
		}
	}
}

