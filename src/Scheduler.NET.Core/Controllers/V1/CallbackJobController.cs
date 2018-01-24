﻿using Hangfire.Annotations;
using Jil;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Scheduler.NET.Core.JobManager;
using Scheduler.NET.Core.JobManager.Job;

namespace Scheduler.NET.Core.Controllers.V1
{
	[Route("api/v1.0/[controller]")]
	public class CallbackJobController : BaseController<CallbackJob>
	{
		public CallbackJobController(IJobManager<CallbackJob> jobManager, ILoggerFactory loggerFactory, ISchedulerConfiguration configuration) : base(jobManager, loggerFactory, configuration)
		{
		}
	}
}