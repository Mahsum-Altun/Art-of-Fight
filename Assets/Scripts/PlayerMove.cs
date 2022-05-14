using UnityEngine;

[System.Serializable]
public enum SIDE {Left, Mid, Right}

public class PlayerMove : MonoBehaviour
{
   public SIDE m_Side = SIDE.Mid;
   float NewXPos = 0f;
   public bool SwipeLeft;
   public bool SwipeRight;
   public float XValue;
   private CharacterController m_char;
   private Animator m_Animator;
   public float FwdSpeed;
   private float x;
   private float y;
   public float SpeedDodge;

   void Start()
   {
       transform.position = Vector3.zero;
       m_char = GetComponent<CharacterController>();
       m_Animator = GetComponent<Animator>();
   }

   void Update()
   {
      SwipeLeft = Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow);
      SwipeRight = Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow);
      if(SwipeLeft)
      {
          if(m_Side == SIDE.Mid)
          {
              NewXPos = -XValue;
              m_Side = SIDE.Left;
          }
          else if(m_Side == SIDE.Right)
          {
              NewXPos = 0;
              m_Side = SIDE.Mid;
          }
      }
      else if(SwipeRight)
      {
          if(m_Side == SIDE.Mid)
          {
              NewXPos = XValue;
              m_Side = SIDE.Right;
          }
          else if(m_Side == SIDE.Left)
          {
              NewXPos = 0;
              m_Side = SIDE.Mid;
          }
      }
      //m_char.Move((NewXPos - transform.position.x) * Vector3.right);
      Vector3 moveVector = new Vector3(x - transform.position.x, y * Time.deltaTime, FwdSpeed * Time.deltaTime);
        x = Mathf.Lerp(x, NewXPos, Time.deltaTime * SpeedDodge);
        m_char.Move(moveVector);
   }

   public void Anim1()
   {
     m_Animator.Play("Punching Bag");
   }
   public void Anim2()
   {
       m_Animator.Play("Kicking");
   }
   public void Anim3()
   {
       m_Animator.Play("Fireball");
   }


}
