using UnityEngine;
using System.Collections;

public class CamTexture : MonoBehaviour {

    WebCamTexture back;

    // Use this for initialization
    void Start()
    {
        //GameObject cube = GameObject.FindWithTag("screen");
        back = new WebCamTexture();
        GetComponent<Renderer>().material.mainTexture = back;

        back.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }

}
