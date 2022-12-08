using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewBuildReadyObjects",menuName = "ScriptableObjects/Construction/BuildReady")]
public class SO_BuildReady : ScriptableObject
{   
    public List<GameObject> buildingSteps;
    public GameObject finishedBuildObject; //finished build obj
    public float buildTime;


}
