using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : HealthSystem
{


    protected override void OnDeath()
    {
        SceneManager.LoadScene(0);
    }
}
