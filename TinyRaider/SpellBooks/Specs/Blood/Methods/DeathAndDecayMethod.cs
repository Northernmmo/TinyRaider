using TinyRaider.Helpers;
using Styx;
using System.Threading.Tasks;

namespace TinyRaider.SpellBooks.Specs.Blood
{
	public partial class BloodSpells : TinyRaiderSpells<BloodTalents>
	{
		public async Task<bool> DeathAndDecayMethod()
		{
			if (Globals.CurrentTarget == null)
				return false;

			// TODO
			return false;

			if (!await DeathAndDecay.Cast(StyxWoW.Me)) return false;

			LastSpell = DeathAndDecay;
			return true;
		}
	}
}
