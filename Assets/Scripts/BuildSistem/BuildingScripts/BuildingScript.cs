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
    private BuildingManager buildingManager;
    public GameObject followVis;
    public GameObject objectHolder;
    //public Transform objectHolder;
    
    public bool isBuilding;
    private Vector3 followPos;
    private Vector3 startPos;
    private Vector3 endPos;


    private void Start()
    {
        
        cam = Camera.main;
        isBuilding = true;
        buildingManager = GameObject.Find("BuildingManager").GetComponent<BuildingManager>();
    }
    void Update()
    {
        if(isBuilding)
        {
            Follow();
        }
    }
    void LateUpdate()
    {
        if(isBuilding)
        {
            if(Input.GetMouseButtonDown(0))
            {
                startPos = followPos;
            }
            if (Input.GetMouseButtonUp(0))
            {
                CreateFloor();
            }
        }
    }

    private void Follow(){
        RaycastHit hit;
            Ray hitPoint = cam.ScreenPointToRay(Input.mousePosition);
            //Debug.Log(hitPoint);
            if(Physics.Raycast(hitPoint, out hit)){
                if(hit.transform.gameObject.tag == "Ground"){
                    Vector3 rawPos;
                    rawPos = hit.point;

                    followPos.x = Mathf.Round(rawPos.x);
                    followPos.y = Mathf.Round(rawPos.y);
                    followPos.z = Mathf.Round(rawPos.z);
                }
            }
            followVis.transform.position = followPos;
    }

    public void CreateFloor(){
        int startX = Mathf.RoundToInt(startPos.x);
        int endX = Mathf.RoundToInt(followPos.x);

        int startZ = Mathf.RoundToInt(startPos.z);
        int endZ = Mathf.RoundToInt(followPos.z);
        //Flipping the values of X and Z is start > end
        if(endX < startX){
            int tmp = startX;
            startX = endX;
            endX = tmp;
        }
        if(endZ < startZ){
            int tmp = startZ;
            startZ = endZ;
            endZ = tmp;
        }
       
        for (int x = startX; x <= endX ; x++)
        {
            for (int z = startZ; z <= endZ ; z++)
            {
                Vector3 newTilePos = new Vector3((float)x, startPos.y , (float)z);

                if(!buildingManager.tilePos.Contains(newTilePos)){
                    buildingManager.tilePos.Add(newTilePos);
                    GameObject go = (GameObject)Instantiate(buildReadyFloor.finishedBuildObject,newTilePos,Quaternion.identity,objectHolder.transform);
                    
                    //ghostFloor.ghost.transform.SetParent(objectHolder.transform);

                }else{
                    Debug.Log("The tile is occupied");
                }
            }
        }
    }
}
