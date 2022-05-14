using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTriggerTwo : MonoBehaviour
{
    public Animator PlayerAnimControl2;


  private void OnTriggerEnter(Collider other)
   {
       if(this.PlayerAnimControl2.GetCurrentAnimatorStateInfo(0).IsTag("1"))
       {
          Debug.Log("G anmim 1");
       }
       else if(this.PlayerAnimControl2.GetCurrentAnimatorStateInfo(0).IsTag("2"))
       {
           Debug.Log("GG anmim 2");
       }
       else if(this.PlayerAnimControl2.GetCurrentAnimatorStateInfo(0).IsTag("3"))
       {
           Debug.Log("animasyon 3 geçti");
       }
       else if(this.PlayerAnimControl2.GetCurrentAnimatorStateInfo(0).IsTag("4"))
       {
           Debug.Log("GG");
       }
   }
}
