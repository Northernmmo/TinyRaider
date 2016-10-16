using Styx;
using Styx.WoWInternals;
using System.Collections.Generic;

namespace TinyRaider.SpellBooks.Specs.Unholy
{
	public partial class UnholySpells : TinyRaiderSpells<UnholyTalents>
	{
		private UnholyTalents _myTalents;
		public override UnholyTalents MyTalents
		{
			get
			{
				if (_myTalents == null)
				{
					_myTalents = new UnholyTalents();
				}
				return _myTalents;
			}
			set
			{
				_myTalents = value;
			}
		}
	}
}
