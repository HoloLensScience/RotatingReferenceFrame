using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBarrel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject earth = GameObject.Find("Earth2D");
        Vector3 scaleTmp = this.transform.localScale;
        Debug.Log(scaleTmp);
        
        scaleTmp.x /= earth.transform.localScale.x;
        scaleTmp.y /= earth.transform.localScale.y;
        scaleTmp.z /= earth.transform.localScale.z;
        Debug.Log(scaleTmp);

       // this.transform.localScale = scaleTmp;

        this.transform.parent = earth.transform;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
