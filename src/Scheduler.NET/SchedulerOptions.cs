using System.Collections.Generic;

namespace Scheduler.NET
{
	public class HangfirefireOptions
	{
        /// <summary>
        /// 数据库类型
        /// </summary>
		public StorageType StorageType { get; set; }
		public string ConnectionString { get; set; }

        /// <summary>
        /// 架构名
        /// </summary>
        public string SchemaName { get; set; } = "dbo";
	}

	public class CacheOptions
	{
		public StorageType Type { get; set; }
		public string ConnectionString { get; set; }
	}

	public class SchedulerOptions : ISchedulerOptions
	{
		public const string SectionName = "SchedulerNet";

		public HangfirefireOptions Hangfire { get; set; }

		public StorageType StorageType { get; set; }

		public string ConnectionString { get; set; }

		public bool UseToken { get; set; }

		public HashSet<string> Tokens { get; set; }

		public string TokenHeader { get; set; }

		public HashSet<string> IgnoreCrons { get; set; }

		public CacheOptions Cache { get; set; }
	}
}
