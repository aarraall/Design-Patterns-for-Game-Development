using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons.Command_Pattern.Scripts
{
    public abstract class Command
    {
        public abstract void Execute(Animator anim);
    }

    public class PerformJump : Command
    {
        public override void Execute(Animator anim)
        {
            anim.SetTrigger("isJumping");
        }
    }
    public class DoNothing : Command
    {
        public override void Execute(Animator anim)
        {
        }
    }
    public class PerformPunch : Command
    {
        public override void Execute(Animator anim)
        {
            anim.SetTrigger("isPunching");
        }
    }
    public class PerformKick : Command
    {
        public override void Execute(Animator anim)
        {
            anim.SetTrigger("isKicking");
        }
    }
}