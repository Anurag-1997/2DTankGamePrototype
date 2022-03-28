using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GunRotation : MonoBehaviour
{
    public Vector3 dir;
    public float angle;
    public PhotonView pview;

    private void Start()
    {
        pview = GetComponent<PhotonView>();
    }
    // Update is called once per frame
    void Update()
    {
        if(pview.IsMine)
        {
            dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
            angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, -90f) * Quaternion.AngleAxis(angle, Vector3.forward);
        }
        
        
    }
    
}
