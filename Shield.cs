using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{

    public GameObject shieldPrefab;
    private GameManager gameManager;
    private PlayerShield playerShield;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float shieldDuration = 5f; // duration in seconds

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            if (playerShield != null)
            {
                playerShield.ActivateShield(shieldDuration);
                Destroy(gameObject); // remove the power-up after collection
            }
        }
    }
}
