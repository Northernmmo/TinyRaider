using TinyRaider.SpellBooks.Talents;

namespace TinyRaider.SpellBooks.Specs.Unholy
{
	public class UnholyTalents : TinyRaiderTalents
	{
		#region Tier 1
		private Talent _finalVerdict;
		public Talent FinalVerdict
		{
			get
			{
				if (_finalVerdict == null)
				{
					_finalVerdict = new Talent() { Name = "Final Verdict", Row = 1, Column = 1 };
				}
				return _finalVerdict;
			}
			set
			{
				_finalVerdict = value;
			}
		}

		private Talent _executionSentence;
		public Talent ExecutionSentence
		{
			get
			{
				if (_executionSentence == null)
				{
					_executionSentence = new Talent() { Name = "Execution Sentence", Row = 1, Column = 2 };
				}
				return _executionSentence;
			}
			set
			{
				_executionSentence = value;
			}
		}

		private Talent _consecration;
		public Talent Consecration
		{
			get
			{
				if (_consecration == null)
				{
					_consecration = new Talent() { Name = "Consecration", Row = 1, Column = 3 };
				}
				return _consecration;
			}
			set
			{
				_consecration = value;
			}
		}
		#endregion

		#region Tier 2
		private Talent _theFiresOfJustice;
		public Talent TheFiresOfJustice
		{
			get
			{
				if (_theFiresOfJustice == null)
				{
					_theFiresOfJustice = new Talent() { Name = "The Fires of Justice", Row = 2, Column = 1 };
				}
				return _theFiresOfJustice;
			}
			set
			{
				_theFiresOfJustice = value;
			}
		}

		private Talent _zeal;
		public Talent Zeal
		{
			get
			{
				if (_zeal == null)
				{
					_zeal = new Talent() { Name = "Zeal", Row = 2, Column = 2 };
				}
				return _zeal;
			}
			set
			{
				_zeal = value;
			}
		}

		private Talent _greaterJudgment;
		public Talent GreaterJugdment
		{
			get
			{
				if (_greaterJudgment == null)
				{
					_greaterJudgment = new Talent() { Name = "Greater Jugdment", Row = 2, Column = 3 };
				}
				return _greaterJudgment;
			}
			set
			{
				_greaterJudgment = value;
			}
		}
		#endregion

		#region Tier 3
		private Talent _fistOfJustice;
		public Talent FistOfJustice
		{
			get
			{
				if (_fistOfJustice == null)
				{
					_fistOfJustice = new Talent() { Name = "Fist of Justice", Row = 3, Column = 1 };
				}
				return _fistOfJustice;
			}
			set
			{
				_fistOfJustice = value;
			}
		}

		private Talent _repentance;
		public Talent Repentance
		{
			get
			{
				if (_repentance == null)
				{
					_repentance = new Talent() { Name = "Repentance", Row = 3, Column = 2 };
				}
				return _repentance;
			}
			set
			{
				_repentance = value;
			}
		}

		private Talent _blindingLight;
		public Talent BlindingLight
		{
			get
			{
				if (_blindingLight == null)
				{
					_blindingLight = new Talent() { Name = "Blinding Light", Row = 3, Column = 3 };
				}
				return _blindingLight;
			}
			set
			{
				_blindingLight = value;
			}
		}
		#endregion

		#region Tier 4
		private Talent _virtuesBlade;
		public Talent VirtuesBlade
		{
			get
			{
				if (_virtuesBlade == null)
				{
					_virtuesBlade = new Talent() { Name = "Virtue's Blade", Row = 4, Column = 1 };
				}
				return _virtuesBlade;
			}
			set
			{
				_virtuesBlade = value;
			}
		}

		private Talent _bladeOfWrath;
		public Talent BladeOfWrath
		{
			get
			{
				if (_bladeOfWrath == null)
				{
					_bladeOfWrath = new Talent() { Name = "Blade of Wrath", Row = 4, Column = 2 };
				}
				return _bladeOfWrath;
			}
			set
			{
				_bladeOfWrath = value;
			}
		}

		private Talent _divineHammer;
		public Talent DivineHammer
		{
			get
			{
				if (_divineHammer == null)
				{
					_divineHammer = new Talent() { Name = "Divine Hammer", Row = 4, Column = 3 };
				}
				return _divineHammer;
			}
			set
			{
				_divineHammer = value;
			}
		}
		#endregion

		#region Tier 5
		private Talent _justcarsVengeance;
		public Talent JusticarsVengeance
		{
			get
			{
				if (_justcarsVengeance == null)
				{
					_justcarsVengeance = new Talent() { Name = "Justicar's Vengeance", Row = 5, Column = 1 };
				}
				return _justcarsVengeance;
			}
			set
			{
				_justcarsVengeance = value;
			}
		}

		private Talent _eyeForAnEye;
		public Talent EyeForAnEye
		{
			get
			{
				if (_eyeForAnEye == null)
				{
					_eyeForAnEye = new Talent() { Name = "Eye for an Eye", Row = 5, Column = 2 };
				}
				return _eyeForAnEye;
			}
			set
			{
				_eyeForAnEye = value;
			}
		}

		private Talent _wordOfGlory;
		public Talent WordOfGLory
		{
			get
			{
				if (_wordOfGlory == null)
				{
					_wordOfGlory = new Talent() { Name = "Word of Glory", Row = 5, Column = 3 };
				}
				return _wordOfGlory;
			}
			set
			{
				_wordOfGlory = value;
			}
		}
		#endregion

		#region Tier 6
		private Talent _divinteIntervention;
		public Talent DivineIntervention
		{
			get
			{
				if (_divinteIntervention == null)
				{
					_divinteIntervention = new Talent() { Name = "Divine Intervention", Row = 6, Column = 1 };
				}
				return _divinteIntervention;
			}
			set
			{
				_divinteIntervention = value;
			}
		}

		private Talent _cavalier;
		public Talent Cavalier
		{
			get
			{
				if (_cavalier == null)
				{
					_cavalier = new Talent() { Name = "Cavalier", Row = 6, Column = 2 };
				}
				return _cavalier;
			}
			set
			{
				_cavalier = value;
			}
		}

		private Talent _sealOfLight;
		public Talent SealOfLight
		{
			get
			{
				if (_sealOfLight == null)
				{
					_sealOfLight = new Talent() { Name = "Seal of Light", Row = 6, Column = 3 };
				}
				return _sealOfLight;
			}
			set
			{
				_sealOfLight = value;
			}
		}
		#endregion

		#region Tier 7
		private Talent _divinePurpose;
		public Talent DivinePurpose
		{
			get
			{
				if (_divinePurpose == null)
				{
					_divinePurpose = new Talent() { Name = "Divine Purpose", Row = 7, Column = 1 };
				}
				return _divinePurpose;
			}
			set
			{
				_divinePurpose = value;
			}
		}

		private Talent _crusade;
		public Talent Crusade
		{
			get
			{
				if (_crusade == null)
				{
					_crusade = new Talent() { Name = "Crusade", Row = 7, Column = 2 };
				}
				return _crusade;
			}
			set
			{
				_crusade = value;
			}
		}

		private Talent _holyWrath;
		public Talent HolyWrath
		{
			get
			{
				if (_holyWrath == null)
				{
					_holyWrath = new Talent() { Name = "Holy Wrath", Row = 7, Column = 3 };
				}
				return _holyWrath;
			}
			set
			{
				_holyWrath = value;
			}
		}
		#endregion
	}
}
