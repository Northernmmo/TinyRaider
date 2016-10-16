using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows.Media;

using Styx;
using Styx.Common;
using Styx.CommonBot;
using Styx.TreeSharp;
using Styx.WoWInternals;
using Styx.CommonBot.Routines;
using CommonBehaviors.Actions;

using TinyRaider.Rotations;
using TinyRaider.Rotations.Specs;
using TinyRaider.Managers;

namespace TinyRaider
{
	public partial class TinyRaider : CombatRoutine
	{
		#region Required Overrides
		public override string Name { get { return "[Hewk] TinyRaider v1.0"; } }

		public override WoWClass Class { get { return StyxWoW.Me.Class ; } }

		public override CapabilityFlags SupportedCapabilities
		{
			get
			{
				return CapabilityFlags.All;
			}
		}


		public override void Initialize()
		{
			Lua.Events.AttachEvent("PLAYER_REGEN_DISABLED", OnCombatStarted);

			Talents.Init();
		}

		private void OnCombatStarted(object sender, LuaEventArgs e)
		{
			Helpers.Logger.PrintLog("Entered Combat");
		}

		public override void Pulse()
		{
			Helpers.Globals.ForceUpdate();
			CheckSpec();
			base.Pulse();
		}
		#endregion

		#region Behaviors
		public override Composite CombatBehavior { get { return new ActionRunCoroutine(ctx => MyRotation.Combat()); } }
		#endregion

		#region Rotation/Spec Handling
		private IRotation _myRotation;
		private IRotation MyRotation
		{
			get
			{
				if (_myRotation == null)
				{
					_myRotation = GetRotation(CurrentSpec);
				}
				return _myRotation;
			}
		}
		private IRotation GetRotation(WoWSpec spec)
		{
			switch (spec)
			{
				case WoWSpec.DeathKnightBlood:
					return new Blood();
				case WoWSpec.DeathKnightUnholy:
					return new Unholy();
				case WoWSpec.RogueOutlaw:
					return new Outlaw();
				default:
					return new Blood();
			}
		}

		private WoWSpec _currentSpec;
		public WoWSpec CurrentSpec
		{
			get
			{
				if (_currentSpec != StyxWoW.Me.Specialization)
				{
					_currentSpec = StyxWoW.Me.Specialization;
					_myRotation = GetRotation(_currentSpec);
					Helpers.Logger.PrintLog("Changed Specialization to: " + _currentSpec + ".");
				}
				return _currentSpec;
			}
		}
		private void CheckSpec()
		{
			var _spec = CurrentSpec;
		}
		#endregion
	}
}