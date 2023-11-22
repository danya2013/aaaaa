using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaa : MonoBehaviour
{
    [SerializeField]
private GameObject obj;
    [SerializeField]
private GameObject jbo_star;
    [SerializeField]
private GameObject jbo_border;
  public float moveSpeed;
    public Vector3 dir;
    public float turnSpeed;
    float targetAngle;
    Vector3 currentPos;
    bool play=true;
    Vector3 direction;
    Vector2 spawn;
    void Start()
    {
        dir = Vector3.up;
        InvokeRepeating ("Start1", 5f, 500f);
    }
    void Start1(){
        play = true;
        direction = new Vector3(Random.Range(-3.0f,3.0f),Random.Range(-4.0f,4.0f),0); //random position in x and y
        spawn = new Vector2(jbo_star.transform.position.x - Random.Range(-100.0f,100.0f),jbo_star.transform.position.y + Random.Range(-100.0f,100.0f)); //random position in x and y
        Instantiate (obj, spawn, Quaternion.identity);
    }
    void Update()
    {
         currentPos = transform.position;//current position of gameObject
        if(play)
        { //calculating direction
        dir = direction - currentPos;  
   
        dir.z = 0;
        dir.Normalize ();
            play = false;
        }  
        
        Vector3 target = dir * moveSpeed + currentPos;  //calculating target position
        transform.position = Vector3.Lerp (currentPos, target, Time.deltaTime);//movement from current position to target position
         targetAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90; //angle of rotation of gameobject
        transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.Euler (0, 0, targetAngle), turnSpeed * Time.deltaTime); //rotation from current direction to target direction
        
    }
    void OnCollisionEnter2D()
    {
       
            CancelInvoke ();//stop call to start1 method
            direction = new Vector3 (Random.Range (-3.0f, 3.0f), Random.Range (-4.0f, 4.0f), 0); //again provide random position in x and y
            play = true;
   
    }
    void OnCollisionExit2D()
    {
        InvokeRepeating ("Start1", 5f, 500f);
    }
    private void OnTriggerEnter(Collider jbo_border)
    {
        if(jbo_border.gameObject.tag == "border")
        InvokeRepeating ("Start1", 5f, 500f);
    }
}
