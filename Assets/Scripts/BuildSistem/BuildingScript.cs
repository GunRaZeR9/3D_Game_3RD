using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class BuildingScript : MonoBehaviour
{
    public SO_Ghost ghostFloor;
    public SO_BuildReady buildReadyFloor;
    private Camera cam;
    public bool isBuilding;


    private void Start()
    {
        cam = Camera.main;
        isBuilding = false;
    }
    void Update()
    {
        if(isBuilding)
        {
            RaycastHit hit;
            Ray hitPoint = cam.ScreenPointToRay(Input.mousePosition);
        }
    }
    void LateUpdate()
    {
        if(isBuilding)
        {
            if(Input.GetMouseButtonDown(0))
            {

            }
            if (Input.GetMouseButtonUp(0))
            {
                
            }
        }
    }
}
