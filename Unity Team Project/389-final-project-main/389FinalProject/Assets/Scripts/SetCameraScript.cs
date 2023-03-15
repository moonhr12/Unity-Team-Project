using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCameraScript : MonoBehaviour
{
    public Camera fp;
    public Camera tp;
    public Camera td;

    private void Start()
    {
        tp.enabled = true;
        fp.enabled = false;
        td.enabled = false;
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            tp.enabled = false;
            fp.enabled = true;
            td.enabled = false;
        }
        else if (Input.GetKey(KeyCode.T))
        {
            tp.enabled = true;
            fp.enabled = false;
            td.enabled = false;
        }
        else if (Input.GetKey(KeyCode.O))
        {
            tp.enabled = false;
            fp.enabled = false;
            td.enabled = true;
        }
    }
}
