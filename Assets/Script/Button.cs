using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject painelLoja;
   public RectTransform rectTransform;

    private void Start()
    {
        //painelLoja.SetActive(false);
     //   ContenteSizeExit(null);
    }
    public void OnButtonLojaTrue()///Ativa loja
   {
        painelLoja.SetActive(true);
   }

    public void OnButtonLojaFalse()//Desativa Loja
    {
        painelLoja.SetActive(false);
    }

    public void BuyItens(float valor)//Remove o Saldo
    {
        FindObjectOfType<GameManager>().RemoverSaldo(valor);
    }

    public void AddIten(GameObject obj)//Salva o iten
    {
         FindObjectOfType<GameManager>().AddIten(obj.GetComponent<ItenDisplay>().iten.hash);
    }


    public void ContenteSizeExit()//Chama a função que deixa a content na posição inicial
    {
        StartCoroutine(ContentCorontine());
    }

    public IEnumerator ContentCorontine()//Levanta a Barra para a posição inicial
    {
        for (int i = 0; i < 93; i++)
        {
            yield return new WaitForSeconds(0.002f);
            rectTransform.GetComponent<RectTransform>().localPosition = new Vector3(0.0f, i, 0.0f);
        }
       

    }

    public void LoadScene()
    {
        SceneManager.LoadScene("Game");

    }
}
