﻿namespace Scripts
{
    using UnityEngine;

    [CreateAssetMenu(fileName = "Potion", menuName = "Item/Consumable/Potion",
        order = 0)]

    public class Potion : Item
    {
        public int Recovery;
    }
}
