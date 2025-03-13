using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lever : MonoBehaviour, IInteractable
{
    [SerializeField] bool isSingleUse;
    bool isUsed;
    public UnityEvent OnActive;

    public void Interact()
    {
        if (isSingleUse)
        {
            if (isUsed)
            {
                return;
            }
            isUsed = true;
            
        }
        OnActive?.Invoke();
    } 
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact(GameObject item)
    {
        throw new System.NotImplementedException();
    }
}
