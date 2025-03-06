using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterStatus : MonoBehaviour,IDamageable
{
    [SerializeField] float lifeMax;
    [SerializeField] float speed;
     float life;
    
    public float Speed { get => speed;}
    public float LifeMax { get => lifeMax;}

    public void TakeDamege(float damege)
    {
        life -= damege;
        if(life <= 0)
        {
            Destroy(gameObject);
        } 
    }


    // Start is called before the first frame update
    void Awake()
   {
        life = lifeMax;
        
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
