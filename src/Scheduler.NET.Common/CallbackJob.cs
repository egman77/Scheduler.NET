using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;

namespace Scheduler.NET.Common
{
	public sealed class CallbackJob : BaseJob
	{
		[Required]
		[Url]
		public string Url { get; set; }

        public HttpMethod Method { get; set; }//= HttpMethod.Get;

        public string MethodString { get { return this.Method?.Method; }}


        public override string ToString()
		{
			return JsonConvert.SerializeObject(this);
		}
	}
}
