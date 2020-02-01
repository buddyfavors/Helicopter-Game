using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

namespace HelicopterECS
{
    public class InputSystem : ComponentSystem
    {

        private string horizontalAxis = "Horizontal";
        private string verticalAxis = "Vertical";
        private string jumpButton = "Jump";

        struct PlayerData
        {
            public readonly int Length;

            public ComponentDataArray<PlayerInput> Input;
        }

        [Inject] private PlayerData m_Players;

        protected override void OnUpdate()
        {
            for (int i = 0; i < m_Players.Length; i++)
            {
                UpdatePlayerInput(i);
            }
        }

        private void UpdatePlayerInput(int i)
        {
            PlayerInput pi;

            pi.Move.x = SimpleInput.GetAxis(horizontalAxis);
            pi.Move.y = SimpleInput.GetAxis(verticalAxis);
            pi.UpMove = SimpleInput.GetAxis(jumpButton);

            m_Players.Input[i] = pi;
        }
    }
}