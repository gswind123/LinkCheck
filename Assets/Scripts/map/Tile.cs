using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Windning.LinkCheck {
	public class Tile : MonoBehaviour {

		public Material faceMat;

		void Awake() {
			setFaceTexture (faceMat);
		}

		// Use this for initialization
		void Start () {
		}

		// Update is called once per frame
		void Update () {

		}

		public void setFaceTexture(Material mat) {
			faceMat = mat;
			if (faceMat) {
				MeshRenderer renderer = this.GetComponent<MeshRenderer> ();
				if (renderer) {
					renderer.materials = new Material[]{
						faceMat	
					};
				}
			}
		}

	}

}
