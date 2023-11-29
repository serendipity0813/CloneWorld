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
            Debug.Log("�α��ν���");

    }

    private void NameChange()
    {
        // �Է¹��� �ؽ�Ʈ�� ������ �Ҵ�
        PlayerName.text = EnterName.text;
        MyTxt.text = EnterName.text;
    }




}
