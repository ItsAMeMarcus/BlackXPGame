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

    void OnCollisionEnter(Collision2D other) {
        if( Target.gameObject.tag.Equals("Player") == true ){
          collisionTime = Time.time;
        }   
    }
}
