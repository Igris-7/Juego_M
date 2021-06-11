using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager2 : MonoBehaviour
{

	 public Mario mario;
	 public Dragon dragon;
     public Koopa  koopa;

    // Start is called before the first frame update
    void Start()
    {
        Mario m3= Instantiate (mario) as Mario;
        Koopa k3= Instantiate (koopa) as Koopa;
        Dragon d2= Instantiate (dragon) as Dragon;
        //Dragon d3= Instantiate (dragon) as Dragon;



        m3.Init(20,1);
        k3.Init(23f,-0.6f,false,2f);
        d2.Init(31f,-2.9f,false,2f);
        //d3.Init(39f,1.03f,true,0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
