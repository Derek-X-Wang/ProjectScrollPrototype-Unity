using UnityEngine;
using System.Collections;

public class ScroolDetector : MonoBehaviour {

    public Texture2D[] texs;
    static int index = 2;
    static int state = 0;

    int srollUpMask;
    int srollDownMask;

    float range = 100f;
    Ray eyeRay;
    RaycastHit eyeRayHit;

    GameObject screen1;
    GameObject mainCam;

    // Use this for initialization
    void Awake () {
        screen1 = GameObject.FindGameObjectWithTag("Screen1");
        mainCam = GameObject.FindGameObjectWithTag("MainCamera");
        //screen1.GetComponent<Renderer>().material.mainTexture = texs[index];
        srollUpMask = LayerMask.GetMask("ScrollUp");
        srollDownMask = LayerMask.GetMask("ScrollDown");
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("Scroll");
        eyeRay.origin = mainCam.transform.position;
        eyeRay.direction = mainCam.transform.forward;
        if (Physics.Raycast(eyeRay, out eyeRayHit, range, srollUpMask)){
            //Debug.Log("ScrollUp");
            if(state <= 0 && index > 0){
                //Debug.Log("ScrollUp2222");
                index--;
                screen1.GetComponent<Renderer>().material.mainTexture = texs[index];
                state = 1;
            }
        }else if (Physics.Raycast(eyeRay, out eyeRayHit, range, srollDownMask)){
            //Debug.Log("ScrollDown");
            if (state >= 0 && index < texs.Length - 1){
                index++;
                screen1.GetComponent<Renderer>().material.mainTexture = texs[index];
                state = -1;
            }
        }
        else{
            state = 0;
        }
    }
}
