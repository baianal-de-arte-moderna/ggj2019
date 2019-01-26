using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioListenerScript : MonoBehaviour
{
    public AudioMixer mixer;
    public Transform Player;

    public string[] AudioParams;
    public Transform[] Appliances;

    // Update is called once per frame
    void Update()
    {
        for (var i = 0; i < AudioParams.Length; i++) {
            mixer.SetFloat(AudioParams[i], Vector3.Distance(Appliances[i].position, Player.position) * -1);
        }        
    }
}
