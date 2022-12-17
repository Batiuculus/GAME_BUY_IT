using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PurchaseTarget : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip Music;
    public AudioSource Audio2;
    public AudioClip Music2;
    [SerializeField] ParticleSystem collectParticle1 = null;
    [SerializeField] ParticleSystem collectParticle2 = null;
    [SerializeField] ParticleSystem collectParticle3 = null;
    [SerializeField] ParticleSystem collectParticle4 = null;
    public GameObject other1;
    public GameObject other2;
    public GameObject other3;
    public GameObject other4;
    public Transform target1;
    public Transform target2;
    public Transform target3;
    public Transform target4;
    public Transform player;
    private float distanceA;
    private float distanceB;
    private float distanceC;
    private float distanceD;
    public GameObject MoneyText;
    public float MoneyAtStart;
    public Transform ATM1;
    public Transform ATM2;
    public Transform ATM3;
    public Transform ATM4;
    private float distance1;
    private float distance2;
    private float distance3;
    private float distance4;

    void Start()
    {
        collectParticle1.Stop();
        collectParticle2.Stop();
        collectParticle3.Stop();
        collectParticle4.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        MoneyText.GetComponent<Text>().text = "MONEY LEFT:" + MoneyAtStart +"$";
        distance1 = (ATM1.position - player.position).magnitude;
        distance2 = (ATM2.position - player.position).magnitude;
        distance3 = (ATM3.position - player.position).magnitude;
        distance4 = (ATM4.position - player.position).magnitude;
        if ((distance1<1) && (MoneyAtStart<50))
        {
          MoneyAtStart = MoneyAtStart + 50.0f;
          Audio2.PlayOneShot(Music2);
        }
        if ((distance2<1) && (MoneyAtStart<50))
        {
          MoneyAtStart = MoneyAtStart + 50.0f;
          Audio2.PlayOneShot(Music2);
        }
         if ((distance3<1) && (MoneyAtStart<50))
        {
          MoneyAtStart = MoneyAtStart + 50.0f;
          Audio2.PlayOneShot(Music2);
        }
         if ((distance4<1) && (MoneyAtStart<50))
        {
          MoneyAtStart = MoneyAtStart + 50.0f;
          Audio2.PlayOneShot(Music2);
        }
        distanceA = (target1.position - player.position).magnitude;
        distanceB = (target2.position - player.position).magnitude;
        distanceC = (target3.position - player.position).magnitude;
        distanceD = (target4.position - player.position).magnitude;
     if ((Input.GetKey(KeyCode.P)) && (distanceA<2) && (MoneyAtStart>=50))
        {
            Destroy(other1);
            collectParticle1.Play();
            MoneyAtStart = MoneyAtStart - 50.0f;
            Audio.PlayOneShot(Music);
        }
     if ((Input.GetKey(KeyCode.P)) && (distanceB<2) && (MoneyAtStart>=50))
     {
      Destroy(other2);
      collectParticle2.Play();
      MoneyAtStart = MoneyAtStart - 50.0f;
      Audio.PlayOneShot(Music);
     }
     if ((Input.GetKey(KeyCode.P)) && (distanceC<2) && (MoneyAtStart>=50))
     {
      Destroy(other3);
      collectParticle3.Play();
      MoneyAtStart = MoneyAtStart - 50.0f;
      Audio.PlayOneShot(Music);
     }
     if ((Input.GetKey(KeyCode.P)) && (distanceD<2) && (MoneyAtStart>=50))
     {
      Destroy(other4);
      collectParticle4.Play();
      MoneyAtStart = MoneyAtStart - 50.0f;
      Audio.PlayOneShot(Music);
     }
    }
   
}
