using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{    
    IInteractable interactable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))// Quando não se tem chaves em um "if" se lê apenas a linha de baixo.
            interactable?.Ineteract();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {        
             if(collision.gameObject.TryGetComponent(out IInteractable target))
             {
                    interactable = target;
             }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        interactable = null;
    }
}
