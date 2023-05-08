using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckAudio : MonoBehaviour
{
    public AudioSource duckFootstep;

    void Update() {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            duckFootstep.enabled = true;
        }       
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            duckFootstep.enabled = true;
        }       
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            duckFootstep.enabled = true;
        }        
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            duckFootstep.enabled = true;
        }
        else
        {
            duckFootstep.enabled = false;
        }               
    }
}
