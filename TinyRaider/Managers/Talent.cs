using System.Collections.Generic;
using System.Linq;
using TinyRaider.Helpers;
using Styx;
using Styx.Common;
using Styx.WoWInternals;
using Styx.WoWInternals.WoWObjects;

namespace TinyRaider.Managers
{
	public static class Talents
	{
		public static Dictionary<string, bool> TalentCache = new Dictionary<string, bool>();

		public static void Init()
		{
			using (StyxWoW.Memory.AcquireFrame())
			{
				Lua.Events.AttachEvent("PLAYER_LEVEL_UP", UpdateTalentManager);
				Lua.Events.AttachEvent("CHARACTER_POINTS_CHANGED", UpdateTalentManager);
				Lua.Events.AttachEvent("GLYPH_UPDATED", UpdateTalentManager);
				Lua.Events.AttachEvent("ACTIVE_TALENT_GROUP_CHANGED", UpdateTalentManager);
				Lua.Events.AttachEvent("PLAYER_SPECIALIZATION_CHANGED", UpdateTalentManager);
				Lua.Events.AttachEvent("LEARNED_SPELL_IN_TAB", UpdateTalentManager);
			}
		}

		public static void Detach()
		{
			Lua.Events.DetachEvent("PLAYER_LEVEL_UP", UpdateTalentManager);
			Lua.Events.DetachEvent("CHARACTER_POINTS_CHANGED", UpdateTalentManager);
			Lua.Events.DetachEvent("GLYPH_UPDATED", UpdateTalentManager);
			Lua.Events.DetachEvent("ACTIVE_TALENT_GROUP_CHANGED", UpdateTalentManager);
			Lua.Events.DetachEvent("PLAYER_SPECIALIZATION_CHANGED", UpdateTalentManager);
			Lua.Events.DetachEvent("LEARNED_SPELL_IN_TAB", UpdateTalentManager);
		}

		private static void UpdateTalentManager(object sender, LuaEventArgs args)
		{
			Helpers.Logger.PrintLog("Talent change detected, recaching Talents");
			TalentCache = new Dictionary<string, bool>();
		}

		public static bool IsActive(int row, int column)
		{
			string key = string.Format("{0}{1}", row, column);
			if (TalentCache.ContainsKey(key))
				return TalentCache[key];

			TalentCache[key] = Lua.GetReturnVal<bool>(string.Format("local t = select(4, GetTalentInfo({0}, {1}, GetActiveSpecGroup())) if t then return 1 end return nil", row, column), 0);
			return TalentCache[key];
		}

		public static bool HasPassivHonorTalent(int talentId)
		{
			return StyxWoW.Me.PassiveAuras.Values.Select(a => a.SpellId).Contains(talentId);
		}
	}
}