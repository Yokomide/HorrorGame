using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LookAtPlayer : MonoBehaviour
{
    public GameObject player;
    public AudioClip impact;
    public GameObject screamer;
    public AudioSource _sound;
    private Vector3 target;
    void Start()
    {
        

    }
    // Update is called once per frame
    void Update()
    {
         target = player.transform.position;
        target.y = 0.0f;
        transform.LookAt(target);
        gameObject.GetComponent<NavMeshAgent>().SetDestination(player.transform.position);
        if (Vector3.Distance(gameObject.transform.position, player.transform.position)<=2.5f)
        {
            screamer.SetActive(true);
            _sound.PlayOneShot(impact, 0.7f);
        }
    }
}
