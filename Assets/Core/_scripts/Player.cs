using System;
using System.Linq;
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
        [SerializeField] private float jumpTimeExtended;
        [SerializeField] private int maxJumpCount;

        private float horizontal;
        private int jumpsRemaining;
        private float jumpTime;
        private bool isJumping;

        private void Start()
        {
            this.jumpsRemaining = this.maxJumpCount;
            this.jumpTime = float.MaxValue;
        }

        private void Update()
        {
            this.horizontal = Input.GetAxis("Horizontal");
            this.physics2D.linearVelocityX = this.horizontal * this.speedDelta;

            if (Input.GetButtonDown("Jump") && this.jumpsRemaining > 0)
            {
                this.physics2D.linearVelocityY = this.jumpForceDelta;
                this.jumpsRemaining--;
                this.jumpTime = 0;
                this.isJumping = true;
            }

            if (Input.GetButton("Jump") && this.jumpTime <= this.jumpTimeExtended && this.isJumping)
            {
                this.physics2D.linearVelocityY = this.jumpForceDelta;
                this.jumpTime += Time.deltaTime;
            }
            else
                this.isJumping = false;
        }

        private void OnCollisionEnter2D(Collision2D collisionObjectInfo)
        {
            if (collisionObjectInfo.contacts.FirstOrDefault().normal.y > .8f)
                this.jumpsRemaining = this.maxJumpCount;
        }
    }
}