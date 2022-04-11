using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class BossInputsManager : MonoBehaviour
{
    public BossControls inputs;
    public InputAction pause;
    void Awake()
    {
        inputs = new BossControls();
    }


    void Update()
    {
        if (pause.triggered && LevelProgress.disableControls == false)
        {
            LevelProgress.canDisplayControls = true;
            if (!LevelProgress.isPaused)
            {
                LevelProgress.isPaused = true;
                //LevelProgress.canDisplayControls = true;
                Time.timeScale = 0;
            }
            else
            {
                LevelProgress.isPaused = false;
                LevelProgress.canDisplayControls = false;
                Time.timeScale = 1;
            }
        }

    }

    private void OnEnable()
    {
        pause = inputs.BossInputs.Pause;

        pause.Enable();

    }

    private void OnDisable()
    {
        pause.Disable();

    }
}
