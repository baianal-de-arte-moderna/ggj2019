using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioListenerScript : MonoBehaviour
{
    public AudioMixer mixer;
    public Transform Player;
    public Transform WashingMachine;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mixer.SetFloat("WashMachVol", Vector3.Distance(WashingMachine.position, Player.position) * -1);
    }
}
