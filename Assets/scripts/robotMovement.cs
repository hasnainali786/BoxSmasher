using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotMovement : MonoBehaviour {
  
    [SerializeField]
    private float movementforce;
    public ParticleSystem entery;
    // Use this for initialization
    void Start() {
      

    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        movementforce = 3;
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0, -movementforce);
        if (gameObject.transform.position.z <= -5f)
        {
          gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,-19f);
          gameObject.SetActive(false);
        }
          
	}

    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag=="ball")
        {
            StartCoroutine(die());  
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "walll")
        {
            entery.Play();
        }
    }
    IEnumerator die()
    {
        gameObject.GetComponent<Rigidbody>().AddForceAtPosition(Vector3.forward * 0.2f, Vector3.forward, ForceMode.VelocityChange);
        GetComponent<Animator>().SetBool("die", true);
       // movementforce = 0;
        yield return new WaitForSeconds(GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
        GetComponentInChildren<ParticleSystem>().Play();
        yield return new WaitForSeconds(0.8f);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -19f);
        gameObject.SetActive(false);
    }

}
