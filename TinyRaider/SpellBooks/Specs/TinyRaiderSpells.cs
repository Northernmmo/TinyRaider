using System.Threading.Tasks;
using Styx;
using Styx.WoWInternals;
using System.Collections.Generic;

namespace TinyRaider.SpellBooks.Specs
{
	public abstract class TinyRaiderSpells<T> : ISpellBookExpanded<T>
		where T : TinyRaiderTalents
	{
		public abstract T MyTalents { get; set; }

		private Spell _lastSpell;
		public Spell LastSpell
		{
			get
			{
				if (_lastSpell == null)
				{
					_lastSpell = new Spell();
				}
				return _lastSpell;
			}
			set
			{
				_lastSpell = value;
			}
		}
	}
}