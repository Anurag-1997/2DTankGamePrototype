using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;

public class TankMovement : MonoBehaviour
{
    //public TMP_Text tmptxt;
    //public int score = 0;
    public Animator anim;
    public Camera mainCam;
    private Vector3 offset;
    private Rigidbody2D rb2d;
    public float tankSpeed;
    public PhotonView pview;
    
    
    //public GameManageScript gms;
    //public Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        //GameManageScript.instance.onCoinCollection += TankColorChanger;
        //mainCam = FindObjectOfType<Camera>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(pview.IsMine)
        {
            //offset = new Vector3(0, 0, -10);

            //mainCam.gameObject.transform.position = transform.position + offset;
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += new Vector3(-0.05f, 0, 0);
                //rb2d.velocity = -transform.right * tankSpeed;

                anim.SetTrigger("IsLeft");
                //transform.Rotate(0, 0, 1f);
            }
            if (Input.GetKey(KeyCode.D))
            {
                //transform.position += new Vector3(0.05f, 0, 0);
                transform.position += Vector3.right * 0.05f;
                anim.SetTrigger("IsRight");

                //transform.Rotate(0, 0, -1f);
            }
            if (Input.GetKey(KeyCode.S))
            {
                //transform.position += new Vector3(0, -0.05f, 0);
                //transform.position -= Vector3.up * 0.05f;
                transform.Translate(0, -0.05f, 0);
                anim.SetTrigger("IsDown");

            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, 0.05f, 0);
                anim.SetTrigger("IsUp");

            }
        }
        if (pview.IsMine == false)
        {
            mainCam.enabled = false;
        }
        
        
        //if(score>=100)
        //{
        //    FindObjectOfType<GameManageScript>().LevelCompleted();
        //}
        
        
    }

    void TankColorChanger()
    {
        GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            //score += 10;
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
            //GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f,1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            //tmptxt.text = "Score : " + score.ToString();


            //observer pattern implementation

            //GameManageScript.instance.CoinCollected();

           // GameManageScript.instance.RPC_CoinCollection();

        }
    }
    
}
