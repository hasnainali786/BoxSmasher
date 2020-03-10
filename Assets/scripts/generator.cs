using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class generator : MonoBehaviour {
	



	public GameObject[] cubePF;
	int d;
    bool gen= false;
	int random;

	// Use this for initialization
	void Start () {
		//InvokeRepeating("C",1f,1.25f);
		random = Random.Range (0, 5);

			StartCoroutine (C ());
	}

	// Update is called once per frame
	void Update ()
    {
        //if (playerScript.reward == 1 && gen == false)
        //{
        //    random = Random.Range(0, 9);
        //    gen = true;
        //    StartCoroutine(C());
        //}

	}

	IEnumerator C() {
		


			cubePF [random].SetActive (true);
			yield return new WaitForSeconds (1.5f);
			d = random;
			random = Random.Range (0, 5);
			if (random == d) {
				if (random < 3) {
					random++;
				} else if (random >= 3) {
					random--;
				}
			}

			StartCoroutine (C ());
			//Instantiate (cubePF [random], new Vector3 (cubePF [random].transform.position.x, cubePF [random].transform.position.y, cubePF [random].transform.position.z), Quaternion.identity);

	
		//objects destroy



	

	}






}
