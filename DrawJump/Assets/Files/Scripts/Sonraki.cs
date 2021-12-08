using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sonraki : MonoBehaviour
{
    
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        int nextBuildIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextBuildIndex);
    }
}
