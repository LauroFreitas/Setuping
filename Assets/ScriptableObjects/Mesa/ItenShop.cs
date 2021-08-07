using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "iten", menuName = "Iten Loja")]

public class ItenShop : ScriptableObject
{
    public int Id;
    public string descisao;
    public Sprite imagemIten;
    public float valor;

}
