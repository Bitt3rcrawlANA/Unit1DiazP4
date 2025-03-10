using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    private float a = 0f;
    // Start is called before the first frame update
    void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {

            cam1.SetActive(false);
            cam2.SetActive(true);

        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
    }
}
