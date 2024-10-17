using System;
using UnityEngine;

namespace Oculus.Interaction
{
    public class RespownItem : MonoBehaviour
    {
        private Vector3 respownPoint;
        private void Start()
        {
            this.transform.position = respownPoint;
        }

        private void Respown()
        {
            
        }
    }
}