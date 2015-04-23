using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

    Material cubeMat;
    Color cubeColor = new Color(255, 0, 255);
	// Use this for initialization
	void Start () {
        cubeMat = gameObject.GetComponent<Renderer>().material;
	
	}
	
	// Update is called once per frame
	void Update () {
        cubeColor.r = Mathf.Sin(Time.realtimeSinceStartup);
        cubeColor.g = Mathf.Cos(Time.realtimeSinceStartup);
        cubeColor.b = Mathf.Tan(Time.realtimeSinceStartup);

        cubeMat.color = cubeColor;
	
	}
}
