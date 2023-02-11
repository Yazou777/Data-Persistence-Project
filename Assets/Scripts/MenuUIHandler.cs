using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class MenuUIHandler : MonoBehaviour
{
    public Button startButton;
    public Button exitButton;
    public Button saveButton;
    public Button loadButton;
    public TMP_InputField playerNameInputField;
    // Start is called before the first frame update
    void Start()
    {
        playerNameInputField.text =  MenuManager.Instance.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        MenuManager.Instance.playerName = playerNameInputField.text;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        MenuManager.Instance.SavePlayerName();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
    public void SavePlayerName()
    {
        MenuManager.Instance.SavePlayerName();
    }

    public void LoadPlayerName()
    {
        MenuManager.Instance.LoadPlayerName();
        playerNameInputField.text = MenuManager.Instance.playerName;
    }

    /* public void NewPlayerName()
     {

         playerNameInputField.text = MenuManager.Instance.playerName;
     }*/
}
