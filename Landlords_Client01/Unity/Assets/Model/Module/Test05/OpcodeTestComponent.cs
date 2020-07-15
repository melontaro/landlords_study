using System;
using System.Collections.Generic;
/// <summary>
/// 本节学习如何自定义组件，如何给组件添加Awake,Load系统事件方法。
/// </summary>
namespace ETModel
{
	[ObjectSystem]
	public class OpcodeTestComponentSystem : AwakeSystem<OpcodeTestComponent>
	{
		public override void Awake(OpcodeTestComponent self)
		{
			self.Awake();
		}
	}

	[ObjectSystem]
	public class OpcodeTestComponentLoadSystem : LoadSystem<OpcodeTestComponent>
	{
		public override void Load(OpcodeTestComponent self)
		{
			self.Load();
		}
	}

	public class OpcodeTestComponent : Component
	{
		public void Awake()
		{
			Log.Info("程序集初始，执行- OpcodeTest- Awake方法");
		}

		public void Load()
		{
			Log.Info("加载完成，执行- OpcodeTest- Load方法");
		}

		public override void Dispose()
		{
			if (this.IsDisposed)
			{
				return;
			}

			base.Dispose();
		}
	}
}