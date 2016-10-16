using System.Threading.Tasks;
using TinyRaider.SpellBooks;

namespace TinyRaider.Rotations
{
	public interface IRotation
	{
		ISpellBook GetSpells();

		Task<bool> Combat();
	}
}
