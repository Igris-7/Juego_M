using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

     public void Init(float x, float y , bool bDireccion, float fSpeed)
    {
    	transform.position= new Vector2(x, y);
    	GetComponent<SpriteRenderer>().flipX= (bDireccion == false ? true : false);
    	Speed = (bDireccion == false ? fSpeed*-1 : fSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity= new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
    
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Tubo" || collision.gameObject.tag =="Agua")
        {
            GetComponent<Collider2D>().isTrigger = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="Plataforma")
        {
            GetComponent<Rigidbody2D>().mass= 1;
            GetComponent<Rigidbody2D>().gravityScale=1;
        }
    }


}
