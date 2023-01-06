using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Helicopter.Cameras
{
    public class BaseHeliCamera : MonoBehaviour, IHeliCamera
    {

        [Header("Base Camera Properties")]
        public Rigidbody Rb;
        public Transform LookAtTarget;
        protected Vector3 CurrentVelocity = Vector3.zero;
        protected Vector3 TargetPos;

        public virtual void HandleCamera()
        {

        }

        protected virtual void FixedUpdate()
        {
            if (Rb)
            {
                HandleCamera();
            }
        }
    }
}
