using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio_Script : MonoBehaviour
{
    public AudioSource Voice;
    private MeshRenderer MyRender;

    private bool Cooldown = false;

    void Start()
    {
        MyRender = GetComponent<MeshRenderer> ();
        Voice = GetComponent<AudioSource> ();
    }

    public void GazedAt(bool gazing)
    {
        if(gazing && Cooldown != true)
        {
            Voice.Play();
            Cooldown = true;
        }
        else
        {
            Invoke("Cooling_Time",30);
        }
    }

    void Cooling_Time()
    {
        Cooldown = false;
    }
}

