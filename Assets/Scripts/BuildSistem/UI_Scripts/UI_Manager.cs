using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;


public class UI_Manager : MonoBehaviour
{
    [Header("References")]
    [Space(8)]

    public StandardUIReference tile;
}

[System.Serializable]
//separate class for the references
public class StandardUIReference
{
    public UnityEngine.UI.Button button;
    
}
