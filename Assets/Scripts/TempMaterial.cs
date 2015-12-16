using UnityEngine;
using System.Collections;

public class TempMaterial : MonoBehaviour {

    public Texture2D tex;
	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material.mainTexture = tex;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
