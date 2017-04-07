using System;
using UnityEditor;

namespace Windning.LinkCheck {
	[CustomEditor(typeof(Tile))]
	public class TileEditor : Editor{
		void OnSceneGUI() {
			var script = (Tile) serializedObject.targetObject;
			script.initMeshTexture ();
		}
	}
}

