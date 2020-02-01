using System;
using Boo.Lang;
using Unity.Entities;
using Unity.Mathematics;

namespace HelicopterECS
{
    public struct PlayerInput : IComponentData
    {
        public float2 Move;
        public float UpMove;
    }

    public struct HelicopterState : IComponentData
    {

    }
}