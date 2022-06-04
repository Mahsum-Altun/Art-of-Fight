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
   public Animator scoreAnimator;
   public static float FwdSpeed = 0;
   private float x;
   private float y;
   public float SpeedDodge;
   public GameManager gameManager;
   
   

   void Start()
   {
       transform.position = Vector3.zero;
       m_char = GetComponent<CharacterController>();
       m_Animator = GetComponent<Animator>();
   }

   void Update()
   {
       SwipeLeft = MobileInput.Instance.SwipeLeft;
       SwipeRight = MobileInput.Instance.SwipeRight;
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

        if(SwipeRight)
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
        Vector3 moveVector = new Vector3(x - transform.position.x, y * Time.deltaTime, FwdSpeed * Time.deltaTime);
        x = Mathf.Lerp(x, NewXPos, Time.deltaTime * SpeedDodge);
        m_char.Move(moveVector);
        m_char.Move(Physics.gravity * Time.deltaTime);

        if (GameManager.scoreValue == 200)
        {
          FwdSpeed = 15;
        }
          if (GameManager.scoreValue == 500)
          {
            FwdSpeed = 20;
          }
          if (GameManager.scoreValue == 3000)
          {
            FwdSpeed = 30;
          }


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

    private void OnTriggerEnter(Collider other) 
   {
       if (other.gameObject.tag == "Window")
       {
         GameManager.scoreValue += 10;
         scoreAnimator.Play("Score Animation");
       }
       if (other.gameObject.tag == "Wall")
       {
          FindObjectOfType<GameManager>().EndGame(); 
       }
        
   }
   


}
