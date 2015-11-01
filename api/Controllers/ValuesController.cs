using System;
using System.Web.Http;
using System.Threading.Tasks;

namespace api
{
	public class ValuesController:ApiController
	{
		public async Task<object> Get(){
			return await Task.FromResult ("value1");
		}
	}
}

