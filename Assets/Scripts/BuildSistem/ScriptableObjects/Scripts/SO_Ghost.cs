using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewGhostObject",menuName = "ScriptableObjects/Construction/Ghost")]
public class SO_Ghost : ScriptableObject
{   [Header("Game Objects")]
    [Space(8)]
    public GameObject ghost;
   
}
   
