using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[Serializable]

public class PlayerData
{
    public float valor_de_carteira;
    public int level;
    public List<string> itens = new List<string>();
    // public ItenShop iten;
    public PlayerData(Player player)
    {
        this.valor_de_carteira = player.valor_de_carteira;
        this.level = player.level;
        this.level = player.level;
        this.itens = player.itens;
       // this.iten = player.iten;
    }
}
