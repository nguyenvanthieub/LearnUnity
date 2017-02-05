using UnityEngine;
using System.Collections;

public class ButtonManager : MonoBehaviour {

	public Renderer rend;

	void Start() {
		rend = GetComponent<Renderer>();
	}
	void OnMouseEnter() {
		rend.material.color = Color.red;
		Debug.Log ("OnMouseEnter");
	}
//	void OnMouseOver() {
//		rend.material.color -= new Color(0.001F, 0, 0) * Time.deltaTime;
//		Debug.Log ("OnMouseOver");
//	}
//	void OnMouseExit() {
//		rend.material.color = Color.white;
//		Debug.Log ("OnMouseExit");
//	}

}
