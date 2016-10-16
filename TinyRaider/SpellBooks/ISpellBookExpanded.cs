using TinyRaider.SpellBooks.Talents;

namespace TinyRaider.SpellBooks
{
	public interface ISpellBookExpanded<T> : ISpellBook
		where T : ITalents
	{
		T MyTalents { get; set; }
		Spell LastSpell { get; set; }
	}
}
