using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MusicManagerScript : MonoBehaviour
{
    public int[] threatLevel;
    public AudioClip[] songs;
    public HouseManagerScript houseManager;

    private AudioSource ASource;
    private int currentClip;
    // Start is called before the first frame update
    void Start()
    {
        ASource = GetComponent<AudioSource>();
        currentClip = songs.Length-1;
    }

    // Update is called once per frame
    void Update()
    {
        var nextClip = threatLevel.Where(t => t <= houseManager.GetCurrentThreatLevel()).Count() - 1;
        if (nextClip != currentClip)
        {
            currentClip = nextClip;
            var time = ASource.time;
            ASource.clip = songs[currentClip];
            ASource.time = time;
            ASource.Play();
        }
    }

    
}
