using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallFire : MonoBehaviour
{

    private PlayerInput playerInput;

    public GameObject ballPrefab;

    private void Start()
    {
        playerInput = gameObject.GetComponent<PlayerInput>();
    }

    void Update()
    {

        if (playerInput.actions["OnClick"].triggered)
        {
            Instantiate(ballPrefab, transform.position, Quaternion.identity);
        }

    }
}