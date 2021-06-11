using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevador : MonoBehaviour
{
	public float speed;
	Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector2(0,-1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime * speed);
    	if(transform.position.y < -4 && direction.y < 0)
    	{
    		direction.y =-direction.y;
    	}

    	if(transform.position.y > 2 && direction.y >0)
    	{
    		direction.y =-direction.y;
    	}
    }
}
