using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenColour : MonoBehaviour {

    public GameObject dude;
    public Sprite greenButtonSp;
    public Sprite dudeGreen;
    public SpriteRenderer spriteRen;

    // Use this for initialization
    void Start()
    {

        spriteRen = dude.GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        //if (spriteRen.sprite == greenButtonSp)
        //{
            spriteRen.sprite = dudeGreen;

        //}

        //else
        //{
        //    spriteRen.sprite = dudeGreen;
        //}
        
    }
}
