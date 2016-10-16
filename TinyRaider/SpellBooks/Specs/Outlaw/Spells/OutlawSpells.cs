using Styx;
using Styx.WoWInternals;
using System.Collections.Generic;

namespace TinyRaider.SpellBooks.Specs.Outlaw
{
	public partial class OutlawSpells : TinyRaiderSpells<OutlawTalents>
	{
		private OutlawTalents _myTalents;
		public override OutlawTalents MyTalents
		{
			get
			{
				if (_myTalents == null)
				{
					_myTalents = new OutlawTalents();
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
