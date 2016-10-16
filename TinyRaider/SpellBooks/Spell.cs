using Buddy.Coroutines;
using Styx;
using Styx.Common;
using Styx.CommonBot;
using Styx.CommonBot.Coroutines;
using Styx.WoWInternals;
using Styx.WoWInternals.WoWObjects;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TinyRaider.SpellBooks
{
	public class Spell
	{
		public int ID { get; set; }
		public string LocalName { get; set; }
		private WoWSpell _crSpell;
		public SpellFlags SpellFlags { get; set; }
		public bool OffGlobalCooldown { get; set; }
		public WoWSpell CRSpell
		{
			get
			{
				if (_crSpell == null)
				{
					_crSpell = WoWSpell.FromId(this.ID);
				}
				return _crSpell;
			}
			set
			{
				_crSpell = value;
			}
		}

		public async Task<bool> Cast(WoWUnit target = null)
		{
			if (SpellManager.GlobalCooldown && SpellFlags != SpellFlags.OffGlobalCooldown) return false;

			var _target = target ?? Helpers.Globals.CurrentTarget;
			if (_target == null || !_target.IsValid)
				return false;

			if (Helpers.Globals.CurrentTarget != null && SpellFlags == SpellFlags.Facing && !Styx.StyxWoW.Me.IsFacing(Helpers.Globals.CurrentTarget))
				return false;

			if (!SpellManager.CanCast(CRSpell, _target, true, true))
				return false;

			if (!SpellManager.Cast(CRSpell, _target))
				return false;

			Helpers.Logger.PrintLog("Casting {0} ({1})", CRSpell.LocalizedName, CRSpell.Name);

			// Seems to run better doing this, as apposed to SleepForLagDuration
			// It is 'hacky', but it also keeps it async.
			await CommonCoroutines.SleepForLagDuration();
			return true;
		}

		public async Task<bool> CastGroundSpell(System.Numerics.Vector3 targetLoc)
		{
			if (!SpellManager.CanCast(CRSpell))
				return false;

			if (!SpellManager.Cast(CRSpell))
				return false;

			if (!await Coroutine.Wait(1000, () => StyxWoW.Me.CurrentPendingCursorSpell != null))
			{
				Helpers.Logger.PrintLog("Failed to cast ground spell: " + CRSpell.LocalizedName + " (" + CRSpell.Name + ")");
				return false;
			}

			SpellManager.ClickRemoteLocation(targetLoc);

			await CommonCoroutines.SleepForLagDuration();
			return true;
		}
	}

	public enum SpellFlags
	{
		None, Facing, OffGlobalCooldown
	}
}
