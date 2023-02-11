using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIHandler : MonoBehaviour
{
    public Button backButton;
    public TextMeshProUGUI currentPlayerName;

    // Start is called before the first frame update
    void Start()
    {
        if (MenuManager.Instance != null) //important pour pouvoir lance directement la scene main sans passer par le menu
        {
            currentPlayerName.text = MenuManager.Instance.playerName;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

   
}
