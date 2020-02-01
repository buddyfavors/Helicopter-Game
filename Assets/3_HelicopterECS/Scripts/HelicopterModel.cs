using UnityEngine;

namespace HelicopterECS
{
    public class HelicopterModel : MonoBehaviour
    {
        public bool IsOnGround = true;
        public AudioSource HelicopterSound;
        public Rigidbody Helicopter;
        public HeliRotorController MainRotorController;
        public HeliRotorController SubRotorController;

        // to setting
        public float TurnForce = 3f;
        public float ForwardForce = 10f;
        public float ForwardTiltForce = 20f;
        public float TurnTiltForce = 30f;
        public float EffectiveHeight = 100f;

        public float turnTiltForcePercent = 1.5f;
        public float turnForcePercent = 1.3f;


        private float _engineForce;
        public float EngineForce
        {
            get { return _engineForce; }
            set
            {
                MainRotorController.RotarSpeed = value * 80;
                SubRotorController.RotarSpeed = value * 40;

                _engineForce = value;
            }
        }

        private void OnCollisionEnter()
        {
            IsOnGround = true;
        }

        private void OnCollisionExit()
        {
            IsOnGround = false;
        }
    }
}