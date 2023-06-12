using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DIP
{
    public class PlayerManager : CharacterManager
    {
        InputHandler inputHandler;
        Animator anim;
        CameraHandler cameraHandler;
        PlayerLocomotion playerLocomotion;

        public bool isInteracting;

        [Header("Player Flags")]
        public bool isInAir;
        public bool isGrounded;
        public bool canDoCombo;

        private void Awake()
        {
           cameraHandler = FindObjectOfType<CameraHandler>();
        }

        void Start()
        {
            inputHandler = GetComponent<InputHandler>();
            anim = GetComponentInChildren<Animator>();
            playerLocomotion = GetComponent<PlayerLocomotion>();
        }

        void Update()
        {
            float delta = Time.deltaTime;
            isInteracting = anim.GetBool("isInteracting");
            canDoCombo = anim.GetBool("canDoCombo");
            
            inputHandler.TickInput(delta);
            playerLocomotion.HandleRolling(delta);

            
            
        }

        private void FixedUpdate()
        {
            float delta = Time.fixedDeltaTime;
            playerLocomotion.HandleMovement(delta);
            
            playerLocomotion.HandleFalling(delta, playerLocomotion.moveDirection);
            
        }

        private void LateUpdate()
        {
            inputHandler.rollFlag = false;
            inputHandler.x_Input = false;
            inputHandler.y_Input = false;

            float delta = Time.fixedDeltaTime;
            if (cameraHandler != null)
            {
                cameraHandler.FollowTarget(delta);
                cameraHandler.HandleCameraRotation(delta, inputHandler.mouseX, inputHandler.mouseY);
            }

            if (isInAir)
            {
                playerLocomotion.inAirTimer = playerLocomotion.inAirTimer + Time.deltaTime;
            }
        }
    }
}