using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetKeyDown(KeyCode.D))
        {
            this.GetComponent<Animator>().SetTrigger("idle");
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            this.GetComponent<Animator>().SetTrigger("idle");
        }
		if(Input.GetKeyDown(KeyCode.A))
        {
            this.GetComponent<Animator>().SetTrigger("idle");
        }
		if(Input.GetKeyDown(KeyCode.S))
        {
            this.GetComponent<Animator>().SetTrigger("idle");
        }
		if(Input.GetKeyUp(KeyCode.D))
        {
            this.GetComponent<Animator>().SetTrigger("walk");
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            this.GetComponent<Animator>().SetTrigger("walk");
        }
		if(Input.GetKeyUp(KeyCode.A))
        {
            this.GetComponent<Animator>().SetTrigger("walk");
        }
		if(Input.GetKeyUp(KeyCode.S))
        {
            this.GetComponent<Animator>().SetTrigger("walk");
        }
		if(Input.GetKeyDown(KeyCode.LeftShift)){
			this.GetComponent<Animator>().SetTrigger("run");
		}
		if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            this.GetComponent<Animator>().SetTrigger("idle");
        }
		if(Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<Animator>().SetTrigger("jump");
        }
		if(Input.GetKeyUp(KeyCode.Space))
        {
            this.GetComponent<Animator>().SetTrigger("idle");
        }
		if(Input.GetKeyDown(KeyCode.X)){
			this.GetComponent<Animator>().SetTrigger("hello");
		}
		if(Input.GetKeyUp(KeyCode.X)){
			this.GetComponent<Animator>().SetTrigger("idle");
		}
    }
}
