using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShield : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject shieldVisual; // Optional: visual representation of shield
    private bool isShieldActive = false;
    private float shieldTimer = 0f;

    void Update()
    {
        if (isShieldActive)
        {
            shieldTimer -= Time.deltaTime;
            if (shieldTimer <= 0f)
            {
                DeactivateShield();
            }
        }
    }

    public void ActivateShield(float duration)
    {
        isShieldActive = true;
        shieldTimer = duration;
        if (shieldVisual != null)
            shieldVisual.SetActive(true);

        
    }

    public void DeactivateShield()
    {
        isShieldActive = false;
        if (shieldVisual != null)
            shieldVisual.SetActive(false);

    }

    public bool IsShieldActive()
    {
        return isShieldActive;
    }
}
