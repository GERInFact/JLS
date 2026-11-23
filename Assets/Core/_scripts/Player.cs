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
       
       private float horizontal;

       private void Update()
       {
           this.horizontal = Input.GetAxis("Horizontal");
       }

       private void FixedUpdate()
       {
           this.physics2D.linearVelocityX = this.horizontal * this.speedDelta;
       }
    }
}
