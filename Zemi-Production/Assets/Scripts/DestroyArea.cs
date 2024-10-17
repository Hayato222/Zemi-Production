using System;
using UnityEngine;

namespace Oculus.Interaction
{
    public class DestroyArea : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("AtttackItems"))
            {
                Destroy(other.gameObject);
            }
        }
    }
}