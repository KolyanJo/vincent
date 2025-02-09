﻿using Assets.Scripts.Common.Extensions;
using Assets.Scripts.Inventory;
using Assets.Scripts.Npc.Dialogues.Models;
using Newtonsoft.Json;
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Markers
{
    public class PickupableItemMarker: MonoBehaviour
    {
        public string Id { get; } = Guid.NewGuid().ToString();
        public Sprite InventoryImage;
        public string Name;

        public TextAsset DialogueFile;
    }
}