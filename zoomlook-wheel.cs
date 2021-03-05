using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateauto : MonoBehaviour {

    private GameObject MyCube;
    private float t;

    void Start()
    {
        MyCube = GameObject.Find("Cube");
        t = (float)1.5;
    }

    void Update()
    {
        MyCube.transform.Rotate(2*t, 2*t, 2*t);
    }
}
