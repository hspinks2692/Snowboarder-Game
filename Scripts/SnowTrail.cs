using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowTrail : MonoBehaviour
{
    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] ParticleSystem SnowEffect;
    void OnCollisionEnter2D(Collision2D other) 
  {
      if(other.gameObject.tag == "Ground")
      {
        SnowEffect.Play();
      }
  }
  void OnCollisionExit2D(Collision2D other) 
  {
      if(other.gameObject.tag == "Ground")
      {
        SnowEffect.Stop();
      }
  }
}
