using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstatantiateBullet : MonoBehaviour
{
    //public GameObject gunRef;
    public GameObject fireSpawnLocation;
    public GameObject bulletPrefab;
    GameObject tempBullet;
    public float bulletForce;
    public GunRotation gr;
    public AudioSource adsource;
    // Start is called before the first frame update
    void Start()
    {
        gr = GetComponent<GunRotation>();
        adsource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            adsource.Play();
            tempBullet= ObjectPoolerWithQ.instance.GetFromPool("bullets", fireSpawnLocation.transform.position);
            //tempBullet =  Instantiate(bulletPrefab, fireSpawnLocation.transform.position, fireSpawnLocation.transform.rotation);
            tempBullet.GetComponent<Rigidbody2D>().velocity = gr.dir * bulletForce * Time.deltaTime;
           
            
        }
    }

   
}
