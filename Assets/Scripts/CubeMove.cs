using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{

    public Animator doorAnim;

    public AudioSource cubeSFX;
    public AudioClip cubeMoveSFX;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PuzzleTarget"))
        {
            doorAnim.SetTrigger("Open");
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            cubeSFX.clip = cubeMoveSFX;
            cubeSFX.Play();
        }
    }
}
