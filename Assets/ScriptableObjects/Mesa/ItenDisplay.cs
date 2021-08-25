using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItenDisplay : MonoBehaviour
{
    public ItenShop iten;
    public Text descricao;
    public Image imagm;
    public Text cost;


    private void Start()
    {
        //descricao.text = iten.descisao;
        imagm.sprite = iten.imagemIten;
        cost.text = iten.valor.ToString();
    }
}
