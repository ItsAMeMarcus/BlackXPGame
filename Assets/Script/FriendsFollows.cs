using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendsFollows : MonoBehaviour
{

    public float Speed;
    public float StoppingDistance;
    private Transform Target;
    bool collision2D;
    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        GameObject player = GameObject.FindGameObjectWithTag("Player");     
        Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, Target.position) > StoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
            Debug.Log(Target.position);
        }
    }

    // void OnCollisionEnter(Collider collision){
    //     if(collision.gameObject.tag == "Player")
    //     {
    //       Physics.IgnoreCollision(collider, GetComponent<Collider>());
    //     }   
    // }
}
