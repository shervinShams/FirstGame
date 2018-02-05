using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedColour : MonoBehaviour {

    public GameObject dude;
    public Sprite redButtonSp;
    public Sprite dudeRed;
    public SpriteRenderer spriteRen;

    // Use this for initialization
    void Start()
    {

        spriteRen = dude.GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        //if (spriteRen.sprite == redButtonSp)
        //{
            spriteRen.sprite = dudeRed;
        //}
        //else
        //{
        //    spriteRen.sprite = dudeRed;
        //}
    }
}
