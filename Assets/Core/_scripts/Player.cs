using System;
using UnityEngine;

namespace Core._scripts
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D physics2D;
        [SerializeField] private float speedDelta;
        [SerializeField] private float jumpForceDelta;
        [SerializeField] private float jumpTimeExtended;
        [SerializeField] private int maxJumpCount;
        [SerializeField] private Transform feetTransform;
        [SerializeField] private float detectionRadius;
        [SerializeField] private LayerMask detectionLayers;


        private float horizontal;
        private int jumpsRemaining;
        private float jumpTime;
        private bool isJumping;
        private float fallTime;

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
                this.fallTime = 0;
            }

            if (Input.GetButton("Jump") && this.jumpTime <= this.jumpTimeExtended && this.isJumping)
            {
                this.physics2D.linearVelocityY = this.jumpForceDelta;
                this.jumpTime += Time.deltaTime;
            }
            else
            {
                this.fallTime += Time.deltaTime;
                this.isJumping = false;
            }
        }

        private void FixedUpdate()
        {
            if (Physics2D.OverlapCircle(this.feetTransform.position, this.detectionRadius, this.detectionLayers) ==
                null || this.fallTime < .1f) return;

            this.jumpsRemaining = this.maxJumpCount;
            this.fallTime = 0;
        }

#if UNITY_EDITOR
        private void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(this.feetTransform.position, this.detectionRadius);
        }

#endif
    }
}