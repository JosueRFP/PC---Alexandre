using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterStatus : MonoBehaviour
{
    [SerializeField] float lifeMax;
    [SerializeField] float speed;
    float life;

    public float Speed { get => speed;}

    // Start is called before the first frame update
    void Awake()
   {
        life = lifeMax;
        print("Pai");
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
