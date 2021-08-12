using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderZone : MonoBehaviour
{
    public GameObject ponter;

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == ponter)
        {
            ponter.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ponter)
        {
            ponter.SetActive(true);
        }
    }

}
