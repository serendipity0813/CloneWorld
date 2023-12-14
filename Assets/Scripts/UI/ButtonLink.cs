using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonlink : MonoBehaviour
{
    // Start is called before the first frame update 

    public bool hidden1 = false;
    public bool hidden2 = false;
    public bool hidden3 = false;
    public bool clear1 = false;
    public bool clear2 = false;
    public bool clear3 = false;
    public GameObject HiddenUI1;
    public GameObject HiddenUI2;
    public GameObject HiddenUI3;

    public void GameStartButton()
    {

        if (hidden3 == true && clear1 == true && clear2 == true && clear3 == true)
        {
            HiddenUI3.SetActive(true);
            //SceneManager.LoadScene("MiniGame1");
        }
        else
        {
            hidden3 = true;
            clear1 = true;
        }
    }

    public void TILButton()
    {

        if (hidden1 == true && clear1 == true)
        {
            HiddenUI2.SetActive(true);
            clear2 = true;
            //SceneManager.LoadScene("MiniGame2");
        }
        else
        {
            Application.OpenURL("https://docs.google.com/forms/d/e/1FAIpQLSeCYwfcHZnG6URB7blUd0rCfMaNjyvPAqWZeQBE9he3H2XhHQ/viewform");
            hidden1 = true;
        }

    }
    public void CodeKataButton()
    {


        if (hidden2 == true && clear2 == true)
        {
            HiddenUI2.SetActive(true);
            clear3 = true;
            //SceneManager.LoadScene("MiniGame3");
        }
        else
        {
            Application.OpenURL(" https://docs.google.com/forms/d/e/1FAIpQLSduIuX-AsMhatLozQyP76qnlRhNISGXyQrRB0GxtR4xJA0A7A/viewform?usp=sf_link");
            hidden2 = true;
        }
    }
    public void CodeKataNotionButton()
    {
        Application.OpenURL("https://www.notion.so/teamsparta/6f6f701d2c3643af86328355520a0540");
        hidden2 = true;
    }

    public void EndingButton()
    {
        //SceneManager.LoadScene("Ending");
    }



}
