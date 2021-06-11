using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Mario mario;
	public Koopa koopa;
    void Start()
    {
        Mario m1= Instantiate (mario) as Mario;
        Koopa k1= Instantiate (koopa) as Koopa;
        Koopa k2= Instantiate (koopa) as Koopa;

        m1.Init(-9,5);
        k1.Init(-2f,-3.15f,false, 2f);
        StartCoroutine("Esperar");
        k2.Init(4f,-0.7f,true,2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Esperar()
    {
    	yield return new WaitForSeconds(10);
    	
    }

    
}
