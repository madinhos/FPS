using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectCounter : MonoBehaviour {

    float objectCount;

    GUIText Display;

    void Update()
    {
        objectCount = UnityEditor.UnityStats.vboTotal;
      
        Debug.Log(objectCount);
    }
}
