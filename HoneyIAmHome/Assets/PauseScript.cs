using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    bool is_paused;
    // Start is called before the first frame update
    void Start()
    {
        is_paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Cancel") > 0f) {
            is_paused = !is_paused;
            this.ChangeGameState(is_paused);
        }
    }

    void ChangeGameState(bool paused) {
        Time.timeScale = paused? 0f:1f;
        Time.fixedDeltaTime = paused? 0f:1f;
    }
}
