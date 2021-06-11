using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mario : MonoBehaviour
{
	public float speed;
	public float salto;
	public SpriteRenderer srMario;

    bool bPlataforma;//saber si pisa la plataforma  si esta en la plataforma activa salto sino no

    // Start is called before the first frame update
    void Start()
    {
        bPlataforma=false; //por defecto no pisa la pltaforma y no podrá hacer doble salto;
    }

    public void Init(int x, int y)
    {
    	transform.position =new Vector2(x,y);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) && bPlataforma ==true)
        {
        	GetComponent<Rigidbody2D>().velocity=
        	new Vector2(GetComponent<Rigidbody2D>().velocity.x,salto);
            bPlataforma=false; //para evitar que haga salto concatenado;

        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
        	srMario.flipX= true;
        	GetComponent<Rigidbody2D>().velocity=
        	new Vector2(-speed,GetComponent<Rigidbody2D>().velocity.y);
        }

          if(Input.GetKey(KeyCode.RightArrow))
        {
        	srMario.flipX= false;
        	GetComponent<Rigidbody2D>().velocity=
        	new Vector2(speed,GetComponent<Rigidbody2D>().velocity.y);
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="Plataforma" || collision.gameObject.tag == "Elevador")
        {
            bPlataforma =true;
        }
        if(collision.gameObject.tag =="Lava" || collision.gameObject.tag =="Koopa" )
        {
            Debug.Log("Perdio");
            SceneManager.LoadScene(0);
        }

        if(collision.gameObject.tag =="Agua" || collision.gameObject.tag =="Dragon")
        {
            Debug.Log("Perdio");
            SceneManager.LoadScene(0);
        }

        if(collision.gameObject.tag =="Puerta")
        {
            SceneManager.LoadScene(1);
        }

        if(collision.gameObject.tag =="Tubo")
        {
            Debug.Log("Final");
        }
    }


}
