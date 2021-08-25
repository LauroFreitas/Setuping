using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public InputField inputText;
    public Text valor_de_carteira_UI;
    public Text itenCompradoNome;
    public GameObject inventario;
    private void Start()
    {

        PlayerLoad();//Recupera os dados salvos pelos jogadores
    }
    /*
    public void AdicionarSaldo()//Atualiza os valores da carteira com o Text
    {
        FindObjectOfType<Player>().valor_de_carteira = float.Parse(inputText.text.ToString());
    }
    */

    private void Update()
    {
        //PlayerLoad();
    }
    public void RemoverSaldo(float valor)//Remove o saldo da carteira pelo valor estipulado na hr da transação da compra do iten
    {
        FindObjectOfType<Player>().valor_de_carteira += valor;
        SaveGame();//Salva que a operação
        valor_de_carteira_UI.text = FindObjectOfType<Player>().valor_de_carteira.ToString();
    }

    public void AddIten(string hash)
    {
        FindObjectOfType<Player>().itens.Add(hash);
        Debug.Log(hash);
        SaveGame();
       
    }
    public void SaveGame()
    {
        SaveSystem.PlayerSave(FindObjectOfType<Player>());
    }
    public void PlayerLoad()
    {
        PlayerData data = SaveSystem.PlayerLoad();
        FindObjectOfType<Player>().valor_de_carteira = data.valor_de_carteira;
        FindObjectOfType<Player>().level = data.level;


       
        for (int i = 0; i < data.itens.Count; i++)
        {
            /*
          if (data.itens.Count > 0)
          {
               data.itens.Clear();
               SaveGame();

          }
             */
            FindObjectOfType<Player>().itens.Add(data.itens[i]);
          Debug.Log(FindObjectOfType<Player>().itens[i]);
        
        }

        valor_de_carteira_UI.text = FindObjectOfType<Player>().valor_de_carteira.ToString();

        if (itenCompradoNome!=null)
        itenCompradoNome.text = FindObjectOfType<Player>().itens.ToString();
    }

}
