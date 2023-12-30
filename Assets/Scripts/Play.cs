using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Play : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject btn_play;
    public GameObject balls;
    public GameObject spawnLocation;
    public Transform stopLocation;
    public float speed = .5f;

    private bool cam1Active = true;

    public void Start()
    {
        
    }
    public void OnButtonClick()
    {
        if (cam1Active) {
            cam1.SetActive(false);
            cam2.SetActive(true);
            cam1Active = false;
            btn_play.SetActive(false);
            MoveChildBall();
        }
        else
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam1Active = true;
        }
        
    }

    private void MoveChildBall()
    {
        Transform firstChild = balls.transform.GetChild(0);
        firstChild.position = spawnLocation.transform.position;
        firstChild.rotation = Quaternion.identity;
        firstChild.localScale = spawnLocation.transform.localScale;
        Rigidbody childRigidbody = firstChild.GetComponent<Rigidbody>();
        if (childRigidbody != null)
        {
            childRigidbody.isKinematic = true;
        }
        StartCoroutine(MoveToStopLocation());
    }

    private System.Collections.IEnumerator MoveToStopLocation()
    {
        Transform firstChild = balls.transform.GetChild(0);
        while (firstChild.position != stopLocation.position)
        {
            // Move the object towards the stop location gradually
            firstChild.position = Vector3.MoveTowards(firstChild.position, stopLocation.position, speed * Time.deltaTime);
            yield return null;
        }
    }
}
