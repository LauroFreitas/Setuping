using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public GameObject painelLoja;

    private void Start()
    {
       painelLoja.SetActive(false);
    }
    public void OnButtonLojaTrue()
   {
        painelLoja.SetActive(true);
   }

    public void OnButtonLojaFalse()
    {
        painelLoja.SetActive(false);
    }

    public void BuyItens(float valor)
    {
        FindObjectOfType<GameManager>().RemoverSaldo(valor);
    }
}
