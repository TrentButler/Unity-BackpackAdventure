﻿

namespace Scripts
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Events;

    public class BackpackBehaviour : MonoBehaviour
    {
        [System.Serializable]
        public class OnItemAdd : UnityEvent<Item> { }
        public OnItemAdd onItemAdd;
        public Backpack BagConfig;
        public List<Item> Items;
        public bool DEBUG = false;

        public bool AddToBackpack(Item item)
        {
            Items.Add(item);
            onItemAdd.Invoke(item);
            return true;
        }

        public bool RemoveFromBackpack(Item item)
        {
            if (Items.Contains(item))
            {
                string tmpkey = item.GetType().ToString();
                string itemkey = tmpkey.Remove(0, 8);
                Debug.Log(itemkey);
                Instantiate(Resources.Load("RuntimePrefabs/" + itemkey), transform.position, transform.rotation);
                //tmp.GetComponent(itemkey + "Behaviour").
                Items.Remove(item);
                return true;
            }
            return false;
        }

        public bool RemoveFromBackpack()
        {
            foreach (var item in Items)
            {
                //string tmpkey = item.GetType().ToString();                
                //string itemkey = tmpkey.Remove(0, 8);
                //string itemkey = tmpkey;
                //Debug.Log(itemkey);
                //Instantiate(Resources.Load("RuntimePrefabs/" + itemkey), transform.position, transform.rotation);
                Items.Remove(item);
                return true;
            }
            return false;
        }

        private bool ChangeBackpackConfig(Backpack newconfig)
        {
            //_currentconfig = newconfig;
            return true;
        }

        private bool AddConfigToBackpack(Backpack newconfig)
        {
            foreach (var item in newconfig.Items)
            {
                AddToBackpack(item);
                return true;
            }
            return false;
        }

        private void _display_rawbackpack()
        {
            //-LOG ALL BACKPACK CONTENTS TO CONSOLE
            Items.ForEach(x => { Debug.Log(x.Name); });
        }

        // Use this for initialization
        void Start()
        {
            Items = new List<Item>();

            foreach (var item in BagConfig.Items)
            {
                AddToBackpack(Instantiate(item));
            }

        }

        // Update is called once per frame
        void Update()
        {
            if (DEBUG)
                _display_rawbackpack();

            if (Input.GetKeyDown(KeyCode.Space))
            {
                RemoveFromBackpack();
            }
        }
    }
}