using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour
{
    public GameObject karakter;
    int sayici = 0;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.gravity = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Physics2D.gravity = new Vector2(0,-40);
            launchChar();
            sayici++;
        }
        
    }
    private void launchChar()
    {
        if (Input.GetMouseButtonUp(0)&& sayici<1)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(70f,100f),Random.Range(50f,90f));
            
        }
    }

    
        
    
}
