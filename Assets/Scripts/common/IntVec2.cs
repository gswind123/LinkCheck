using System;

namespace Windning.LinkCheck {

	[System.Serializable]
	public class IntVec2 {
		public int x;
		public int y;
		public int width() {
			return x;
		}
		public int height() {
			return y;
		}

		public static bool operator == (IntVec2 a, IntVec2 b) {
			if (a as object == null || b as object == null) {
				return a as object == null && b as object == null;
			}
			return a.x == b.x && a.y == b.y;
		}
		public static bool operator != (IntVec2 a, IntVec2 b) {
			return !(a == b);
		}

	}
}

