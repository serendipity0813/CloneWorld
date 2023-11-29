using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
