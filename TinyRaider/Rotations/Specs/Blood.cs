using System.Threading.Tasks;

using TinyRaider.Helpers;
using TinyRaider.SpellBooks.Specs.Blood;

using Styx;
using Styx.CommonBot;

namespace TinyRaider.Rotations.Specs
{
	public class Blood : Rotation<BloodSpells>
	{
		#region Behavior Methods

		public async override Task<bool> Combat()
		{
			AutoTarget();

			Globals.UpdateCombat();

			if (!StyxWoW.Me.GotTarget || StyxWoW.Me.Mounted || StyxWoW.Me.IsDead || StyxWoW.Me.CurrentTarget == StyxWoW.Me || StyxWoW.Me.IsStealthed) return false;

			if (SpellManager.GlobalCooldownLeft.TotalMilliseconds > 200) return true;

			// Main
			if (await MySpells.BloodBoilMethod()) return true;
			if (await MySpells.MarrowrendMethod()) return true;
			if (await MySpells.DeathAndDecayMethod()) return true;
			if (await MySpells.HeartStrikeMethod()) return true;

			return false;
		}
		#endregion
	}
}
