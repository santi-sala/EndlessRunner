using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elBartoCoin : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "tiago")
        {
            CollectCoin();
        }
    }

    private void CollectCoin()
    {
        animator?.SetTrigger("CollectCoin");
        GameStats._Instance.CollectCoin();
    }

    public void OnShowWorldChunk()
    {
        //Debug.Log("K PASA");
        animator?.SetTrigger("Idle");
    }

}
