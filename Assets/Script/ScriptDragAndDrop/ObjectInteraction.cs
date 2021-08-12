using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public GameObject obj;
    
    public void VirarObj()
    {
        obj.transform.Rotate(0,30,0);
    }

}
