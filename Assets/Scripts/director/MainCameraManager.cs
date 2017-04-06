using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Windning.LinkCheck {
	public class MainCameraManager : MonoBehaviour {

		public Camera mainCamera;

		public float width, height;

		void Awake() {
			mainCamera = this.GetComponent<Camera>();

			float aspect = Screen.width / Screen.height;
			this.height = Screen.height / (mainCamera.orthographicSize * 2);
			this.width = this.height * aspect;
		}

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {

		}
	}

}
