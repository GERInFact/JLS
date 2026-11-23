using System;
using UnityEngine;

namespace Core._scripts
{
    public class Player : MonoBehaviour
    {
        //TODO: Make player move horizontally using A and D 
        // Make player jump using space, including double jump and extended jump mechanics 
        // Implement custom fall physics / behaviour by manipulating the downwards velocity 
        // correctly move player using the unity physics via Rigidbody 2D

        [SerializeField] private Rigidbody2D physics2D;
        [SerializeField] private float speedDelta;
        [SerializeField] private float jumpForceDelta;
        [SerializeField] private int maxJumpCount;

        private float horizontal;
        private int jumpsRemaining;

        private void Start()
        {
            this.jumpsRemaining = this.maxJumpCount;
        }

        private void Update()
        {
            this.horizontal = Input.GetAxis("Horizontal");
            this.physics2D.linearVelocityX = this.horizontal * this.speedDelta;

            if (Input.GetButtonDown("Jump") && this.jumpsRemaining > 0)
            {
                this.physics2D.linearVelocityY = this.jumpForceDelta;
                this.jumpsRemaining--;
            }
        }
    }
}