using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public InputField inputText;
    public Text valor_de_carteira_UI;

    #region SIngleton:Game

    public static GameManager Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    #endregion

    private void Start()
    {
        valor_de_carteira_UI.text = FindObjectOfType<Player>().valor_de_carteira.ToString();
        PlayerLoad();
    }

    public void AdicionarSaldo()
    {
        FindObjectOfType<Player>().valor_de_carteira = float.Parse(inputText.text.ToString());
        Debug.Log(FindObjectOfType<Player>().valor_de_carteira);
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
        valor_de_carteira_UI.text = FindObjectOfType<Player>().valor_de_carteira.ToString();
    }




}
