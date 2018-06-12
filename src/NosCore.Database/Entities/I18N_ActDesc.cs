﻿using NosCore.Shared.Enumerations;

namespace NosCore.Database.Entities
{
	public class I18N_ActDesc
	{
		public int I18N_ActDescId { get; set; }
		public string Key { get; set; }
		public RegionType RegionType { get; set; }
		public string Text { get; set; }
	}
}