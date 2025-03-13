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
    public void Interact()
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

    public void Interact(GameObject item)
    {
        throw new System.NotImplementedException();
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
