using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNameUI : MonoBehaviour
{
    public TMP_Text PlayerName;
    public TMP_InputField EnterName;
    public GameObject Profile;
    public Text MyTxt;
    private string text;


    private void Start()
    {

    }

    private void Update()
    {

    }
    public void OnClick()
    {

        if (EnterName.text.Length > 1 && EnterName.text.Length < 11)
        {
            Profile.SetActive(false);
            NameChange();
        }
        else
            Debug.Log("로그인실패");

    }

    private void NameChange()
    {
        // 입력받은 텍스트를 변수에 할당
        PlayerName.text = EnterName.text;
        MyTxt.text = EnterName.text;
    }




}
