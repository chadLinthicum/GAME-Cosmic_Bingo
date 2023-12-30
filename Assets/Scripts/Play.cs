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

    private bool cam1Active = true;

    public void Start()
    {
        Debug.Log("foo");
        
    }
    public void OnButtonClick()
    {
        if (cam1Active) {
            //cam1.SetActive(false);
            //cam2.SetActive(true);
            //cam1Active = false;
            //btn_play.SetActive(false);
            LogChildren(balls.transform);
            Transform firstChild = balls.transform.GetChild(0);
            firstChild.position = spawnLocation.transform.position;
            firstChild.rotation = Quaternion.identity;
            firstChild.localScale = spawnLocation.transform.localScale;
            Rigidbody childRigidbody = firstChild.GetComponent<Rigidbody>();
            if (childRigidbody != null)
            {
                childRigidbody.isKinematic = true;
            }
        }
        else
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam1Active = true;
        }
        
    }

    private void LogChildren(Transform parent)
    {
        foreach (Transform child in parent)
        {
            Debug.Log(child.name);
            LogChildren(child);
        }
    }
}
