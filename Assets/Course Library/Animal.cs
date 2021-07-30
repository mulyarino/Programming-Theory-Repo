using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Animal : MonoBehaviour
{

    public GameObject canvas;
    private float A_moveSpeed = 5f;
    bool isGame;
    public float moveSpeed

    {
        get { return A_moveSpeed; }
        set { A_moveSpeed = value; }
    }
        

    [SerializeField]
    private GameObject[] animalPrefab;
   

    public void choice1()
    {
        Instantiate(animalPrefab[0],
         animalPrefab[0].transform.position,
         animalPrefab[0].transform.rotation);
        canvas.gameObject.SetActive(false);
    }
    public void choice2()
    {
        Instantiate(animalPrefab[1], 
        animalPrefab[1].transform.position,
        animalPrefab[1].transform.rotation);
        canvas.gameObject.SetActive(false);
    }
    public void choice3()
    {
        Instantiate(animalPrefab[2],
        animalPrefab[2].transform.position,
        animalPrefab[2].transform.rotation);
        canvas.gameObject.SetActive(false);
    }

    public virtual void Move()
    {
        transform.Translate(Vector3.forward * moveSpeed  * Time.deltaTime);
    }
    
        
    
}
