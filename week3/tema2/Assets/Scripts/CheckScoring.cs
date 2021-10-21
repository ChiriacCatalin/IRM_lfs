using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckScoring : MonoBehaviour
{
    [SerializeField]
    private Canvas myCanvas;
    private Collider aux;

    IEnumerator OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "scoringCheckpoint")
        {
            myCanvas.enabled = true;
            col.gameObject.GetComponent<Collider>().enabled = false;
            aux = col.gameObject.GetComponent<Collider>();
            yield return new WaitForSeconds(5);
            myCanvas.enabled = false;
            aux.enabled = true;
        }
    }
}