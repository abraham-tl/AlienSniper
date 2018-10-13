using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewZoom : MonoBehaviour {
    public float max_Zoom = 60;
    public int min_Zoom = 5;
    public float speed_Zoom = 500;
    public bool active_Zoom;
    //public GameObject[] target;
    //public int i;
    public Camera myCam;
    float ini;
    // Use this for initialization
    void Start() {
        myCam = this.GetComponent<Camera>();
        ini = myCam.fieldOfView;
        //target = new GameObject[i];
        //target = GameObject.FindGameObjectsWithTag("cubes");
    }



    // Update is called once per frame
    void LateUpdate()
    {
        LookAT();

    }
    public void LookAT()
    {
        if (!active_Zoom)
        {
            if (myCam.fieldOfView <= max_Zoom)
            {
                myCam.fieldOfView = min_Zoom;
            }
            else
            {
                active_Zoom = true;
            }
        }
        else
        {
            if (myCam.fieldOfView <= max_Zoom && myCam.fieldOfView >= min_Zoom)
            {
                myCam.fieldOfView -= min_Zoom;
            }
            else
            {
                active_Zoom = false;
            }
        }
    }
    public void Click_zoom()
    {
        if(!active_Zoom)
        {
            active_Zoom = true;
        }
    }
}
