using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class X_RayMode : MonoBehaviour
{
    Camera cam;
    void Start()
    {
        cam = GetComponent<Camera>();        
    }

    void Update()
    {
        var camData = cam.GetUniversalAdditionalCameraData();
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            camData.SetRenderer(0);

        }   
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            camData.SetRenderer(1);

        }    
    }
}
