using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeProximityAttack : MonoBehaviour
{
    public GameObject Cactus;
    public GameObject Rhino;
    public float Distance_;

    [SerializeField] private Animator toAnimate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance_ = Vector3.Distance(Cactus.transform.position, Rhino.transform.position);
        if (Distance_ < 0.25)
        {
            toAnimate.SetBool("closeProximity", true);
           
        }
        else
        {
            toAnimate.SetBool("closeProximity", false);
        }
    }
}
