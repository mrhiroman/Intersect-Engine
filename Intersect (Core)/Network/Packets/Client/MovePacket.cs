﻿using System;

namespace Intersect.Network.Packets.Client
{

    public class MovePacket : CerasPacket
    {

        public MovePacket(Guid mapId, byte x, byte y, byte dir, byte deplDir)
        {
            MapId = mapId;
            X = x;
            Y = y;
            Dir = dir;
            DeplacementDir = deplDir;
        }

        public Guid MapId { get; set; }

        public byte X { get; set; }

        public byte Y { get; set; }

        public byte Dir { get; set; }

        public byte DeplacementDir { get; set; }

    }

}
