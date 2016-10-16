using Styx;
using Styx.CommonBot.Routines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyRaider
{
	public partial class TinyRaider : CombatRoutine
	{
		public override string Name { get { return "[Hewk] TinyRaider v1.0"; } }

		public override WoWClass Class { get { return StyxWoW.Me.Class ; } }

		public override CapabilityFlags SupportedCapabilities
		{
			get
			{
				return CapabilityFlags.All;
			}
		}
	}
}
