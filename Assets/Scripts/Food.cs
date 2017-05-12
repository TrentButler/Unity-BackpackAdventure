﻿namespace Scripts
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "Food", menuName = "Item/Consumable/Food",
        order = 0)]

    public class Food : Consumable
    {
        public int Recover;
    }
}
