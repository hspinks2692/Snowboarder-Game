using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
  [SerializeField] float reload = 0.5f;
  [SerializeField] ParticleSystem CrashEffect;
  bool Crash = false;
  void OnTriggerEnter2D(Collider2D other) 
  {
      if(other.tag == "Ground" && Crash == false)
      {
        Crash = true;
        FindObjectOfType<Cryptic>().DisableControls();
        CrashEffect.Play();
        GetComponent<AudioSource>().Play();
        Invoke("ReloadScene", reload);
      }
  }

  void ReloadScene()
    {
        SceneManager.LoadScene(0); 
    }
}
