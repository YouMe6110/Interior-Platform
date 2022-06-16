using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviewObject : MonoBehaviour
{
    public GameObject wall;
    public GameObject bedSingle;
    public GameObject desk;
    public GameObject chairCushion;

    public GameObject preview_wall;
    public GameObject preview_bedSingle;
    public GameObject preview_desk;
    public GameObject preview_chairCushion;

    GameObject preview;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            preview = preview_wall;
            preview.SetActive(true);
            preview_bedSingle.SetActive(false);
            preview_desk.SetActive(false);
            preview_chairCushion.SetActive(false);
            Build.furniture = wall;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            preview = preview_bedSingle;
            preview.SetActive(true);
            preview_wall.SetActive(false);
            preview_desk.SetActive(false);
            preview_chairCushion.SetActive(false);
            Build.furniture = bedSingle;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            preview = preview_desk;
            preview.SetActive(true);
            preview_wall.SetActive(false);
            preview_bedSingle.SetActive(false);
            preview_chairCushion.SetActive(false);
            Build.furniture = desk;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            preview = preview_chairCushion;
            preview.SetActive(true);
            preview_wall.SetActive(false);
            preview_bedSingle.SetActive(false);
            preview_desk.SetActive(false);
            Build.furniture = chairCushion;
        }

        Build.preview_object = preview;
        Vector3 mouse = Input.mousePosition;
        Ray casepoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;
        if (Physics.Raycast(casepoint, out hit, Mathf.Infinity) && preview)
        {
            preview.transform.position = new Vector3(hit.point.x, hit.point.y + preview.transform.localScale.y / 2, hit.point.z);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            preview.transform.Rotate(0, 90, 0);
        }
    }
}