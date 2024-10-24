﻿using Player;
using UnityEditor;
using UnityEngine;

namespace Editor_Custom {
    [CustomEditor(typeof(PlayerMovementController))]
    public class PlayerMovementController_Editor : Editor {
        private void OnSceneGUI() {
            PlayerMovementController movementController = (PlayerMovementController)target;

            movementController.GroundCheck.position = Handles.PositionHandle(movementController.GroundCheck.position, Quaternion.identity);
        }
    }
}