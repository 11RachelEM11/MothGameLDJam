using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof(PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        public GameObject WinPlat;
        public GameObject M1;
        public GameObject R1;
        public GameObject M2;
        public GameObject M3;
        public GameObject M4;
        public GameObject M5;

        private PlatformerCharacter2D m_Character;
        private bool m_Jump;
        private bool dupText = false;
        private bool dupText2 = false;


        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {
            if (!m_Jump)
            {
                // Read the jump input in Update so button presses aren't missed.
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
            }
        }


        private void FixedUpdate()
        {
            // Read the inputs.
            bool crouch = Input.GetKey(KeyCode.LeftControl);
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            // Pass all parameters to the character control script.
            m_Character.Move(h, crouch, m_Jump);
            m_Jump = false;
        }

        void OnTriggerEnter2D(Collider2D otherThing)
        {
            if (otherThing.tag == "NPC")
            {
                print("I am colliding with" + otherThing);
                if (dupText == false)
                {
                    Instantiate(M1);
                    M1.transform.position = WinPlat.transform.position;
                    dupText = true;
                }
            }
            if (otherThing.tag == "NPC2")
                if (dupText2 == false)
                {
                    Instantiate(M2);
                    M2.transform.position = WinPlat.transform.position;
                    dupText2 = true;
                }
            if (otherThing.tag == "NPC3")
            {
                print("I am colliding with" + otherThing);
                if (dupText == false)
                {
                    Instantiate(M3);
                    M3.transform.position = WinPlat.transform.position;
                    dupText = true;
                }
            }
        }
    }
}
