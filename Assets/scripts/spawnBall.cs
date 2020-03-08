using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBall : MonoBehaviour
{
    public GameObject startpoint;
    public List<GameObject> vfx = new List<GameObject>();
    private GameObject effectToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        effectToSpawn = vfx[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            spawnVfx();
        }
    }

    void spawnVfx()
    {
        GameObject vfx;
        if(startpoint!=null)
        {
            vfx = Instantiate(effectToSpawn, startpoint.transform.position, Quaternion.identity);
        }
    }
}
