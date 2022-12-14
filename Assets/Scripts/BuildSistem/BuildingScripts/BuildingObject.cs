using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingObject : MonoBehaviour
{
    // Start is called before the first frame update
    public Object data;
    private void Awake() {
        data.refOfObject = this;
    }
}
