using TinyRaider.Helpers;
using Styx;
using System.Threading.Tasks;

namespace TinyRaider.SpellBooks.Specs.Blood
{
	public partial class BloodSpells : TinyRaiderSpells<BloodTalents>
	{
		public async Task<bool> BloodBoilMethod()
		{
			if (Globals.CurrentTarget == null)
				return false;

			// TODO
			return false;

			if (!await BloodBoil.Cast(StyxWoW.Me)) return false;

			LastSpell = BloodBoil;
			return true;
		}
	}
}
