using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

using Styx;
using Styx.Common;
using Styx.CommonBot;
using Styx.CommonBot.Coroutines;

using TinyRaider.Managers;
using TinyRaider.Helpers;
using TinyRaider.SpellBooks;

namespace TinyRaider.Rotations
{
	public abstract class Rotation<S> : IRotation
		where S : ISpellBook
	{
		private S _mySpells;
		public S MySpells
		{
			get
			{
				if (_mySpells == null)
				{
					_mySpells = (S)Activator.CreateInstance(typeof(S));
				}
				return _mySpells;
			}
			set
			{
				_mySpells = value;
			}
		}

		public ISpellBook GetSpells()
		{
			return MySpells;
		}

		public abstract Task<bool> Combat();

		public void AutoTarget()
		{
			// TODO select best target in pvp
			if (Globals.CurrentTarget != null) return;

			var units = Unit.UnfriendlyUnits.Where(u => u.Aggro && u.Distance <= 30).OrderBy(u => u.Distance).ThenBy(u => u.HealthPercent).ToList();
			var target = units.FirstOrDefault();

			if (target == null) return;

			Helpers.Logger.DiagnosticLog("Selecting {0} as Target", target.SafeName);

			target.Target();
		}
	}
}
