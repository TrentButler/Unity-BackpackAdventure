﻿namespace Scripts {
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class PotionBehaviour : MonoBehaviour
    {
        public Potion PotionConfig;
        [HideInInspector]
        public Potion _other;

        // Use this for initialization
        void Start()
        {
            _other = Instantiate(PotionConfig);
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider col)
        {
            if(col.tag == "Player")
            {
                col.GetComponentInChildren<BackpackBehaviour>().AddToBackpack(_other);
                Destroy(gameObject);
            }
        }

    }
}
