using System;
using System.Collections;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Lessons.Command_Pattern.Scripts
{
    public class InputHandler : MonoBehaviour
    {
        public GameObject actor;
        private Animator _animator;
        private Command keySpace, keyW, keyP, keyF;
        private int[] numbers = new int[3];

        private void Start()
        {
            keySpace = new PerformJump();
            keyW = new DoNothing();
            keyP = new PerformPunch();
            keyF = new PerformKick();
            _animator = actor.GetComponent<Animator>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                keySpace.Execute(_animator);
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                keyW.Execute(_animator);
            }
            else if (Input.GetKeyDown(KeyCode.P))
            {
                keyP.Execute(_animator);
            }
            else if (Input.GetKeyDown(KeyCode.F))
            {
                keyF.Execute(_animator);
            }
        }
    }
}