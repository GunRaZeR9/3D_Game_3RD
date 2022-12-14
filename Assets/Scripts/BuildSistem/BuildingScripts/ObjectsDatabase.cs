using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class ObjectsDatabase : MonoBehaviour
{
    public List<Object> objectDatabase = new List<Object>();

    public static ObjectsDatabase Instance;

    void Awake()
    {
      Instance = this;  
    }
}

