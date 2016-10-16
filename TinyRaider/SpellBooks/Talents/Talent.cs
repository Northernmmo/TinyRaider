using Styx.WoWInternals;

namespace TinyRaider.SpellBooks.Talents
{
	public class Talent
	{
		public string Name;
		public int Row;
		public int Column;
		public int ID;

		public bool IsActive()
		{
			return Managers.Talents.IsActive(Row, Column);
		}
	}
}
