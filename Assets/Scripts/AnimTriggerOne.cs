using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTriggerOne : MonoBehaviour
{
    public Animator PlayerAnimControl1;


  private void OnTriggerEnter(Collider other)
   {
       if(this.PlayerAnimControl1.GetCurrentAnimatorStateInfo(0).IsTag("1"))
       {
          Debug.Log("GG anmim 1");
       }
       else if(this.PlayerAnimControl1.GetCurrentAnimatorStateInfo(0).IsTag("2"))
       {
           Debug.Log("animasyon 2 geçti");
       }
       else if(this.PlayerAnimControl1.GetCurrentAnimatorStateInfo(0).IsTag("3"))
       {
           Debug.Log("GG anmim 3");
       }
       else if(this.PlayerAnimControl1.GetCurrentAnimatorStateInfo(0).IsTag("4"))
       {
           Debug.Log("GG");
       }
   }
}
