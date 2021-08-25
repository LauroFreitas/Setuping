using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddIShoptens : MonoBehaviour
{
    public GameObject itensShop;
    public List<GameObject> ItensLoja = new List<GameObject>();//Uma lista para adicionar os itens que eu quero iportar para a loja
   

    private void Start()
    {
        AddIten(ItensLoja.Count);//Conta quantos itens tem na loja eu adicionei no inspector e adiciona a loja
    }
    public void AddIten(int quantidade)
    {
       for (int i = 0; i < quantidade; i++)
       {
            itensShop = Instantiate(ItensLoja[i], transform);
       }
    }//Adiciona os itens a loja
}
