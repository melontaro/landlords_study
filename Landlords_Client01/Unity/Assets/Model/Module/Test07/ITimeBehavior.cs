﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETModel
{
	[AttributeUsage(AttributeTargets.Class)]
	public class TimeBehaviorAttribute : BaseAttribute
	{
		public string Type { get; }

		public TimeBehaviorAttribute(string type)
		{
			this.Type = type;
		}
	}
	public static partial class Typebehavior
	{
		public const string Waiting = "Waiting";
		public const string RandTarget = "RandTarget";
	}

	public interface ITimeBehavior
	{
		void Behavior(Entity parent, long time);
	}
}
