using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barak : MonoBehaviour
{
    [SerializeField] float speed;
    private Transform back_t;
    private float back_size;
    private float back_pos;

    void Start()
    {
        back_t = GetComponent<Transform>();
        back_size = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            speed = 5;
        }
        if(Input.GetMouseButtonUp(0))
        {
            speed = 5;
        }
        Move();
    }

    public void Move()
    {
        back_pos += speed * Time.deltaTime;
        back_pos = Mathf.Repeat(back_pos, back_size);
        back_t.position = new Vector3(back_pos, back_pos, 0);
    }
}
