using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairCursor : MonoBehaviour
{
    private void Awake()
    {
        Cursor.visible = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseCurPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mouseCurPos;
    }
}
