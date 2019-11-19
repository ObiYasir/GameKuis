using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Nama  : Obi Yasir Lubis
//NPM   : 1614370311
//Kelas : RPL-MALAM A
public class Tombol : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	public void scene(string scene){
		Application.LoadLevel (scene);
	}
	public void scale(float scale){
		transform.localScale = new Vector2 (1/scale,1*scale);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
