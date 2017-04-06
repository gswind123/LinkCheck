using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Windning.LinkCheck {
	public class Tile : MonoBehaviour {

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {

		}

		public Vector2 getSize() {
			Vector3 size = this.GetComponent<BoxCollider2D> ().bounds.size;
			return new Vector2 (size.x, size.y);
		}

	}

}
