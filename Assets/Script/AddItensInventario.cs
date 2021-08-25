using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItensInventario : MonoBehaviour
{

    public GameObject itensShop;
    
    public void AddIten()
    {
        for (int i = 0; i < FindObjectOfType<Player>().itens.Count; i++)
        {
            itensShop.name = FindObjectOfType<Player>().itens[i] + i;
            GameObject newitensShop = Instantiate(itensShop, transform);
        }
    }//Adiciona os Itens que estão já foram carregados em um inventario somente visual
    public void RemoveChild()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Debug.Log(transform.childCount);
            Destroy(transform.GetChild(i).gameObject);
        }

    }//Quando abrir o inventario novamente os itens serão reinportados novamente removendo os itens instaciados anteriormente
}
