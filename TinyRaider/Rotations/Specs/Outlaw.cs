using System.Threading.Tasks;

using TinyRaider.Helpers;
using TinyRaider.SpellBooks.Specs.Outlaw;

using Styx;
using Styx.CommonBot;

namespace TinyRaider.Rotations.Specs
{
	public class Outlaw : Rotation<OutlawSpells>
	{
		#region Behavior Methods

		public async override Task<bool> Combat()
		{
			AutoTarget();

			Globals.UpdateCombat();

			if (!StyxWoW.Me.GotTarget || StyxWoW.Me.Mounted || StyxWoW.Me.IsDead || StyxWoW.Me.CurrentTarget == StyxWoW.Me || StyxWoW.Me.IsStealthed) return false;

			if (SpellManager.GlobalCooldownLeft.TotalMilliseconds > 200) return true;

			// Main

			return false;
		}
		#endregion
	}
}
