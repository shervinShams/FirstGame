using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowColour : MonoBehaviour {

    public GameObject dude;
    public Sprite yellowButtonSp;
    public Sprite dudeYellow;
    public SpriteRenderer spriteRen;

    // Use this for initialization
    void Start()
    {

        spriteRen = dude.GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        //if (spriteRen.sprite == yellowButtonSp)
        //{
            spriteRen.sprite = dudeYellow;
        //}
        //else
        //{
        //    spriteRen.sprite = dudeYellow;
        //}
    }
}
