using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Windning.LinkCheck {

	public class TileManager : MonoBehaviour {

		public IntVec2 slotSize;
		public Tile tilePrefab;
		private Tile[,] _map_slot;

		private const float kTileWidth = 0.6f;
		private const float kTileHeight = 0.6f;
		private const float kTileThick = 0.2f;

		void Awake() {
			
		}
		// Use this for initialization
		void Start () {
			initTileBoard ();
		}

		// Update is called once per frame
		void Update () {

		}

		#region Private

		private Vector3 calcTilePos(int row, int col) {
			return new Vector3 (kTileWidth * col, 0, kTileHeight * row);
		}
		private Vector3 calcTileSize(int row, int col) {
			return new Vector3 (kTileWidth, kTileHeight, kTileThick);
		}

		private void initTileBoard() {
			Transform board_transform = GetComponent<Transform> ();
			this._map_slot = new Tile[slotSize.y, slotSize.x];
			for (int col = 0; col < slotSize.x; col++) {
				for (int row = 0; row < slotSize.y; row++) {
					Tile tile_obj = Instantiate(this.tilePrefab);
					tile_obj.name = string.Format ("tile_{0:D}_{1:D}", row, col);
					tile_obj.transform.parent = board_transform;
					tile_obj.transform.localPosition = calcTilePos (row, col);
					tile_obj.transform.localScale = calcTileSize (row, col);
				}
			}
		} 

		private void cleanTileBoard() {
			if (_map_slot != null) {
				foreach(Tile tile in _map_slot) {
		#if UNITY_EDITOR
					DestroyImmediate(tile);
		#else
					Destroy (tile);
		#endif
				}
				_map_slot = null;
			}
		}

		#endregion

		#region Editor

		#if UNITY_EDITOR

		private IntVec2 _slot_size_cache = new IntVec2();
		public void OnSceneGUI() {
				_slot_size_cache = slotSize;
//				cleanTileBoard ();
//				initTileBoard ();
			
		}

		#endif

		#endregion
	}

}


