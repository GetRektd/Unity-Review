using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float vertical;
    float horizontal;
    float speed = 5;

    public SpriteRender sprite;

    public Animator anim;

    




    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector2.right * speed * Time.deltaTime * horizontal);

        if(horizontal > 0)

        {

            sprite.flipx = true;
            anim.SetFloat("Accel", 0.2f);

        }  else if (horizontal < 0)

        { 
            sprite = flipx = false;

        } else if (horizontal == 0)

        {
            anim.SetFloat("Accel", 0);
            anim.SetBool("Accel", 0);


        }
    
        
    }
}
