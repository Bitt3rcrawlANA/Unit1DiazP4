using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Finish"))
        {
            Destroy(gameObject);
        }
    }
}
