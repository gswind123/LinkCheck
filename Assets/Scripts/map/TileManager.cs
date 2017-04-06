using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Windning.LinkCheck {

	public class TileManager : MonoBehaviour {

		public IntVec2 slotSize;
		public Tile tilePrefab;
		private Tile[,] _map_slot;

		void Awake() {
			Debug.Log (tilePrefab.getSize());
			this._map_slot = new Tile[slotSize.width(), slotSize.height()];
			for (int row = 0; row < slotSize.width(); row++) {
				for (int col = 0; col < slotSize.height(); col++) {
					Tile item = Instantiate(tilePrefab) as Tile;
					item.transform.parent = this.transform;

				}
			}
		}
		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {

		}
	}

}


