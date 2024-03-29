﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAPI
{
    class GUIAddresses
    {
        public static UInt32 GUIStart = 0x3BE800; // 10.1
        public static UInt32[] TypedMessageOffsets = new UInt32[] { 0x40, 0x44, 0x2C }; // 10.1
        public static UInt32[] WorldWinWidthOffsets = new UInt32[] { 0x30, 0x2C, 0x1C }; // 10.1
        public static UInt32[] WorldWinHeightOffsets = new UInt32[] { 0x30, 0x2C, 0x20 }; // 10.1
        public static UInt32[] WorldWinFromEdge = new UInt32[] { 0x30, 0x34 }; // 10.1
        public static UInt32[] WorldWinFromOppositeEdge = new UInt32[] { 0x44, 0x10, 0x34 }; // 10.1
    }
    class Addresses
    {
        public static UInt32 Cid = 0x553034; // 10.0
        public static UInt32 Xor = 0x3BE1D0; // 10.0
        public static UInt32 Hp = 0x553000; // 10.0
        public static UInt32 MaxHp = 0x55302C; // 10.0
        public static UInt32 Mp = 0x3BE224; // 10.0
        public static UInt32 MaxMp = 0x3BE1D4; // 10.0
        public static UInt32 Soul = 0x3BE210; // 10.0
        public static UInt32 XPos = 0x553038; // 10.0
        public static UInt32 YPos = 0x55303C; // 10.0
        public static UInt32 ZPos = 0x553040; // 10.0
        public static UInt32 Exp = 0x3BE1E0; // 10.0
        public static UInt32 IsConnected = 0x3C7FE0; // 10.0
        public static UInt32 Level = 0x3BE20C; // 10.0
        public static UInt32 LastClicked = 0x54F5B8; // 10.0
    }

    class Hotkeys
    {
        public static UInt32 HKStart = 0x3C5980; // 10.0
        public static UInt32 HKStep = 0x100; // 10.0
        public static UInt32 HKMax = 24; // Constant

        public static UInt32 HKSendStart = 0x3C6970; // Unsure
        public static UInt32 HKSendStep = 0x1; // Unsure

        public static UInt32 HKItemStart = 0x3C8F30; // Unsure
        public static UInt32 HKItemStep = 0x4; // 10.0

        public static UInt32 HKItemUseTypeStart = 0x3C67C0; // Unsure
        public static UInt32 HKItemUseTypeStep = 0x4; // Unsure
    }

    class BListAdresses
    {
        public static UInt32 Start = 0x5A9530; // 10.0
        public static UInt32 Step = 0xC0; // 10.0
        public static int Max = 1300; // Static
        public static UInt32 IdOffset = 0x0; // 10.0
        public static UInt32 TypeOffset = 0x3; // 10.0
        public static UInt32 NameOffset = 0x4; // 10.0
        public static UInt32 ZOffset = 0x24; // 10.0
        public static UInt32 YOffset = 0x28; // 10.0
        public static UInt32 XOffset = 0x2C; // 10.0
        public static UInt32 TimeLastMovedOffset = 0x3C; // 10.0
        public static UInt32 WalkingOffset = 0x50; // 10.0
        public static UInt32 DirectionOffset = 0x38; // 10.0
        public static UInt32 PreviousOffset = 0x58; // 10.0
        public static UInt32 NextOffset = 0x5C; // 10.0
        public static UInt32 OutfitOffset = 0x60; // 10.0
        public static UInt32 MountIdOffset = 0x78; // 10.0
        public static UInt32 BlackSquareOffset = 0x88;
        public static UInt32 HppcOffset = 0x8C; // 10.0
        public static UInt32 SpeedOffset = 0x90;
        public static UInt32 SkullOffset = 0x98;
        public static UInt32 PartyOffset = 0x9C;
        public static UInt32 WarOffset = 0xA8;
        public static UInt32 VisibleOffset = 0xAC;
    }

    class ContainerAddresses
    {
        public static UInt32 ContainerStart = 0x4063E0; // 4219872
        public static UInt32 ContainerMaxSlots = 36;
        public static UInt32 Max = 16;
        public static UInt32 MaxStack = 100;
        public static UInt32 Step = 0x1EC; // 192

        //public static int ContLength = 0xFC; // Container is 60 bytes long plus items, each item is 12 bytes, and max containers is 16, so 252 bytes per container.

        public static UInt32 HasParentOffset = 0;
        public static UInt32 IdOffset = 0xC;
        public static UInt32 AmountOffset = 0x2C;
        public static UInt32 IsOpenOffset = 0x34;
        public static UInt32 VolumeOffset = 0x38;
        public static UInt32 NameOffset = 0x10;
        public static UInt32 ItemsOffset = 0x38 + 0xC;
    }

    class NewContainers
    {
        public static UInt32 ContainerStart = 0x3BDF68; // 10.1
        public static UInt32[] ContainerUnknown = new UInt32[] { 0x634, 0x540 }; // This gets the position of a container, I can't work out which though.
        public static UInt32 Step4 = 0x4ADAB; // 10.1
    }

    class MapAddresses
    {
        public static UInt32 MapStart = 0x5E1B54;
        public static UInt32 MaxTiles = 0x7E0;
        public static UInt32 Step = 0xA8;

        public static UInt32 CountOffset = 0x0;
        public static UInt32 StackOrderOffset = 0x4;
        public static UInt32 ItemOffset = 0x2C;
        public static UInt32 EffectOffset = 0xA4;

    }

    class ItemAddresses
    {
        public static UInt32 Step = 0xC;
        public static UInt32 Id = 0;
        public static UInt32 Unknown2 = 0x4;
        public static UInt32 Count = 0x8;
    }
}
