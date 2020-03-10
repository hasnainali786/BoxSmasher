using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    GameObject target;
    public GameObject balls,startposition;
    Vector3 destination;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            destination = ray.direction;
            target = Instantiate(balls);
            target.transform.position = startposition.transform.position;
           
        }
        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended))
        {
            Touch touch=Input.GetTouch(0);
            var ray = Camera.main.ScreenPointToRay(touch.position);
            destination = ray.direction;
            target = Instantiate(balls);
            target.transform.position = startposition.transform.position;

        }
        if (target != null)
        {
            target.transform.Translate(destination*0.7f);
           // target.transform.position = Vector3.MoveTowards(target.transform.position, destination, 20f);
            Destroy(target, 2f);
        }
    }
    
}
