using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(DestroyObject());
    }
    
    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(4f);
        
        Destroy(gameObject);
    }
}
