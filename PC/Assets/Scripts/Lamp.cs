using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Lamp : MonoBehaviour, IInteractable
{
    [SerializeField] Color disabledColor;
    [SerializeField] Color activateColor;
    SpriteRenderer spriteRenderer;
    bool isON;
    public void Ineteract()
    {
        if (isON)
        {
            isON = false;
            spriteRenderer.color = disabledColor;
        }
        else
        {
            isON = true;
            spriteRenderer.color = activateColor;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
