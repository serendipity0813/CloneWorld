using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonlink : MonoBehaviour
{
    // Start is called before the first frame update 

    public int TIL = 0;
    public int CodeKata = 0;
    public int hidden1 = 0;
    public int hidden2 = 0;
    public int hidden3 = 0;
    public int clear1 = 0;
    public int clear2 = 0;
    public int clear3 = 0;
    public GameObject HiddenUI1;
    public GameObject HiddenUI2;
    public GameObject HiddenUI3;

    public void GameStartButton()
    {
        if(hidden3 == 0 || clear3 ==0)
        {
            //SceneManager.LoadScene("MiniGame1");
            hidden3++;
            clear1++;
        }
        else if(hidden3 > 0 && clear1 > 0 && clear2 > 0 && clear3 > 0)
        {
            HiddenUI3.SetActive(true);
        }
    }

    public void TILButton()
    {
        if(hidden1 == 0)
        {
            Application.OpenURL("https://docs.google.com/forms/d/e/1FAIpQLSeCYwfcHZnG6URB7blUd0rCfMaNjyvPAqWZeQBE9he3H2XhHQ/viewform");
            hidden1++;
        }
        else if(hidden1 > 0 && clear1 > 0)
        {
            HiddenUI2.SetActive(true);
            clear2++;
            //SceneManager.LoadScene("MiniGame2");
        }
    }
    public void CodeKataButton()
    {
        if(hidden2 == 0)
        {
            Application.OpenURL(" https://docs.google.com/forms/d/e/1FAIpQLSduIuX-AsMhatLozQyP76qnlRhNISGXyQrRB0GxtR4xJA0A7A/viewform?usp=sf_link");
            hidden2++;
        }
        else if(hidden2 > 0 && clear2 > 0)
        {
            HiddenUI2.SetActive(true);
            clear3++;
            //SceneManager.LoadScene("MiniGame3");
        }
     }
    public void CodeKataNotionButton()
    {
        Application.OpenURL("https://www.notion.so/teamsparta/6f6f701d2c3643af86328355520a0540");
        hidden2++;
    }

    public void EndingButton()
    {
        //SceneManager.LoadScene("Ending");
    }



}
