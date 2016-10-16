using Styx;
using Styx.WoWInternals;
using System.Collections.Generic;

namespace TinyRaider.SpellBooks.Specs.Blood
{
	public partial class BloodSpells : TinyRaiderSpells<BloodTalents>
	{
		private BloodTalents _myTalents;
		public override BloodTalents MyTalents
		{
			get
			{
				if (_myTalents == null)
				{
					_myTalents = new BloodTalents();
				}
				return _myTalents;
			}
			set
			{
				_myTalents = value;
			}
		}

		private Spell _bloodBoil;
		public Spell BloodBoil
		{
			get
			{
				if (_bloodBoil == null)
				{
					int _id = 50842;
					_bloodBoil = new Spell() { ID = _id, CRSpell = WoWSpell.FromId(_id) };
				}
				return _bloodBoil;
			}
		}

		private Spell _deathAndDecay;
		public Spell DeathAndDecay
		{
			get
			{
				if (_deathAndDecay == null)
				{
					int _id = 43265;
					_deathAndDecay = new Spell() { ID = _id, CRSpell = WoWSpell.FromId(_id), SpellFlags = SpellFlags.OffGlobalCooldown };
				}
				return _deathAndDecay;
			}
		}

		private Spell _heartStrike;
		public Spell HeartStrike
		{
			get
			{
				if (_heartStrike == null)
				{
					int _id = 206930;
					_heartStrike = new Spell() { ID = _id, CRSpell = WoWSpell.FromId(_id) };
				}
				return _heartStrike;
			}
		}

		private Spell _marrowrend;
		public Spell MarrowRend
		{
			get
			{
				if (_marrowrend == null)
				{
					int _id = 195182;
					_marrowrend = new Spell() { ID = _id, CRSpell = WoWSpell.FromId(_id), SpellFlags = SpellFlags.OffGlobalCooldown };
				}
				return _marrowrend;
			}
		}
	}
}
