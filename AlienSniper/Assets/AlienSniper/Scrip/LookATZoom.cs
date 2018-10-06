using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LookATZoom : MonoBehaviour {

    bool active;
    public Image sight;
	// Use this for initialization
	void Start () {
        active = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
        {
            print("HOLA");
            if(active)
            {
                Camera.main.fieldOfView = 4f;
                //gameObject.GetComponent<Camera>().fieldOfView = 4f;
                active = false;
            }
            else
            {
                Camera.main.fieldOfView = 60f;
                active = true;
            }
            Sight();
        }
	}

    public void Sight()
    {
        sight.enabled = !sight.enabled;
    }
}
