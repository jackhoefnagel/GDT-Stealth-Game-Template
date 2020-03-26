using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator playerAnimator;
    public Rigidbody playerRB;
    public Transform playerGraphicsTransform;

    private void Update()
    {
        playerAnimator.SetFloat("playerSpeed", playerRB.velocity.magnitude);

        if (playerRB.velocity.magnitude > 0.1f)
        {
            Quaternion newRotation = new Quaternion();
            newRotation.SetLookRotation(playerRB.velocity);
            playerGraphicsTransform.rotation = newRotation;
        }
    }
}
