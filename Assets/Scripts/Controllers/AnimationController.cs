using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class AnimationController : MonoBehaviour
{
    public Animator Character;
    public GameObject UI;

    public Sprite idle;
    public Sprite idle2;
    public Sprite idle3;
    public Sprite idle4;

    public GameObject MyCharacter;
    public SpriteRenderer player; // 스프라이트 렌더러 선언



    // Start is called before the first frame update
    void Start()
    {
        player = MyCharacter.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) )
        {
            MoveAnimation();
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            AnimationStop();
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            JumpAnimation();
        }

    }

    void MoveAnimation()
    {
            Character.SetBool("Run1",true);
            Character.SetBool("Run2", true);
            Character.SetBool("Run3", true);
            Character.SetBool("Run4", true);
    }

    void JumpAnimation()
    {
        Character.SetTrigger("Jump1");
        Character.SetTrigger("Jump2");
        Character.SetTrigger("Jump3");
        Character.SetTrigger("Jump4");

    }

    void AnimationStop()
    {
            Character.SetBool("Run1", false);
            Character.SetBool("Run2", false);
            Character.SetBool("Run3", false);
            Character.SetBool("Run4", false);
    }

    public void player1Push()
    {       
        Character.SetBool("player1", true);
        Character.SetBool("player2", false);
        Character.SetBool("player3", false);
        Character.SetBool("player4", false);
        player.sprite = idle;
        UI.SetActive(false);

    }  
    
    public void player2Push()
    {
        Character.SetBool("player1", false);
        Character.SetBool("player2", true);
        Character.SetBool("player3", false);
        Character.SetBool("player4", false);
        player.sprite = idle2;
        UI.SetActive(false);

    }

    public void player3Push()
    {
        Character.SetBool("player1", false);
        Character.SetBool("player2", false);
        Character.SetBool("player3", true);
        Character.SetBool("player4", false);
        player.sprite = idle3;
        UI.SetActive(false);

    }

    public void player4Push()
    {
        Character.SetBool("player1", false);
        Character.SetBool("player2", false);
        Character.SetBool("player3", false);
        Character.SetBool("player4", true);
        player.sprite = idle4;
        UI.SetActive(false);

    }



}
