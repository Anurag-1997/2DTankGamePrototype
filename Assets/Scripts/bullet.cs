using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject bulletExplosion;
    private GameObject tempBulletExplosion;
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
        if (collision.gameObject.tag == "Enemy")
        {
            tempBulletExplosion = Instantiate(bulletExplosion.gameObject, this.gameObject.transform.position, Quaternion.identity);
            this.gameObject.SetActive(false);
            Destroy(tempBulletExplosion, 0.5f);
            Destroy(collision.gameObject);
        }
    }

   
}
