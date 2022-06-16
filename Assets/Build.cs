using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{
    static public GameObject furniture;
    static public GameObject preview_object;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject object_clone = Instantiate(furniture, preview_object.transform.position, preview_object.transform.rotation);
        }
    }
}
