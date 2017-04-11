using System;
using UnityEditor;

namespace Windning.LinkCheck {

	[CustomEditor(typeof(TileManager))]
	public class TileManagerEditor : Editor {
		
		void OnSceneGUI() {
			TileManager script = (TileManager) serializedObject.targetObject;
			script.OnSceneGUI ();
		}

	}

}

