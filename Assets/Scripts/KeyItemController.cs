using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KeySystem
{
    public class KeyItemController : MonoBehaviour
    {
        [SerializeField] private bool labDoor = false;
        [SerializeField] private bool labKey = false;

        [SerializeField] private KeyInventory _keyInventory = null;

        private KeyDoorController doorObject;

        private void Start()
        {
            if (labDoor)
            {
                doorObject = GetComponent<KeyDoorController>();
            }
            
        }
        public void ObjectInteraction()
        {
            if (labDoor)
            {
                doorObject.PlayAnimation();
            }
            else if (labKey)
            {
                _keyInventory.hasKey = true;
                gameObject.SetActive(false);
            }
        }
    }
}

