using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bulletPrefab;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }
}