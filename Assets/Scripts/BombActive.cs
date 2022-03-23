using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombActive : MonoBehaviour
{
    public Animator anim;
    public float bombDestroyTime = 0.08f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        anim.SetTrigger("bombactivation");
        Invoke("DestroyBomb", bombDestroyTime);
       // Destroy(this.gameObject);
    }
    void DestroyBomb()
    {
        Destroy(gameObject);
    }
}
