using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float reload = 1.5f; 
    [SerializeField] ParticleSystem FinishedEffect;
    bool Win = false;
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player" && Win == false)
        {
            Win = true;
            FinishedEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", reload);
        }
        
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0); 
    }
}
