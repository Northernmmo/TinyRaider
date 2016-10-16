using System;
using System.Diagnostics;
using System.Linq;
using Styx;
using Styx.WoWInternals;
using Styx.WoWInternals.WoWObjects;

namespace TinyRaider.Helpers
{
	public static class Globals
	{
		public static double MyHp;
		public static uint RunicPower;
		public static int RuneCount;
		public static int ComboPoints;
		public static bool InParty;
		public static bool HealPulsed;
		public static bool Mounted
		{
			get
			{
				var me = StyxWoW.Me;
				return !me.HasAura(164222) &&
					   !me.HasAura(165803) &&
					   !me.HasAura(178807) &&
					   !me.HasAura(157060) &&           //http://www.wowhead.com/spell=157060/rune-of-grasping-earth
					   !me.HasAura(157056) &&
					   (me.Mounted || me.InVehicle);
			}
		}

		public static Stopwatch ForceUpdateScanner = new Stopwatch();
		private static int ForceUpdateScanInterval = 500;

		public static bool InCombat;
		public static int LastKnownGroupMemberSize = 0;

		// Enemies
		public static WoWUnit CurrentTarget;
		public static int EnemiesInRange;
		public static float MeleeRange;

		// Auras
		public static WoWAura CrimsonScourge;

		public static void ForceUpdate()
		{
			if (!ForceUpdateScanner.IsRunning) ForceUpdateScanner.Restart();
			if (ForceUpdateScanner.ElapsedMilliseconds < ForceUpdateScanInterval) return;

			Update();
		}

		public static void Update()
		{
			ForceUpdateScanner.Restart();

			Unit.ResetUnfriendlyUnits = true;
			Unit.ResetGroupMembers = true;

			InCombat = StyxWoW.Me.IsActuallyInCombat;

			MyHp = StyxWoW.Me.HealthPercent;
			CurrentTarget = StyxWoW.Me.CurrentTarget;

			EnemiesInRange = StyxWoW.Me.GotTarget
				? Unit.EnemiesInRange(8 + (int)StyxWoW.Me.CurrentTarget.CombatReach)
				: EnemiesInRange = Unit.EnemiesInRange(8);

			MeleeRange = StyxWoW.Me.GotTarget
				? Math.Max(4f, StyxWoW.Me.CombatReach + 1.3333334f + StyxWoW.Me.CurrentTarget.CombatReach)
				: 4f;

			ComboPoints = StyxWoW.Me.ComboPoints;
			RunicPower = StyxWoW.Me.CurrentRunicPower;
			RuneCount = StyxWoW.Me.CurrentRunes;
			InParty = StyxWoW.Me.GroupInfo.IsInRaid || StyxWoW.Me.GroupInfo.IsInParty;
			LastKnownGroupMemberSize = StyxWoW.Me.GroupInfo.IsInRaid ? StyxWoW.Me.GroupInfo.NumRaidMembers : StyxWoW.Me.GroupInfo.NumPartyMembers;
		}

		public static void UpdateCombat()
		{
			using (StyxWoW.Memory.TemporaryCacheState(true))
			{
			}
		}

		public static void UpdateCombatOutlaw()
		{
			using (StyxWoW.Memory.TemporaryCacheState(true))
			{
				// TODO
			}
		}

		public static void UpdateCombatBlood()
		{
			using (StyxWoW.Memory.TemporaryCacheState(true))
			{
				CrimsonScourge = StyxWoW.Me.GetAuraById(81136);
			}
		}

		public static void UpdateCombatUnholy()
		{
			using (StyxWoW.Memory.TemporaryCacheState(true))
			{
				// TODO
			}
		}

		public static void UpdateCombatHoly()
		{
			using (StyxWoW.Memory.TemporaryCacheState(true))
			{
				// TODO
			}
		}
	}
}
