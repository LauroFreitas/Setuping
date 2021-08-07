using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddIShoptens : MonoBehaviour
{
    public GameObject itensShop;

    private void Start()
    {
        AddIten(10);
    }
    public void AddIten(int quantidade)
    {
       for (int i = 0; i < quantidade; i++)
       {
            itensShop.name = "Iten" + i;
            itensShop = Instantiate(itensShop, transform);
       }
    }
}
