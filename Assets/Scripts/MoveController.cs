using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class MoveController : MonoBehaviour, IBeginDragHandler, IDragHandler, IPointerClickHandler
{
    [SerializeField] private CharacterController characterPlayer;

    private AudioSource audioSource;

    [SerializeField] private AudioClip jump_sound;
    [SerializeField] private AudioClip dogde_sound;

    private Vector3 dir;
    private float gravity = -20f;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if(Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y))
        {
            if(eventData.delta.x > 0)
            {
                //DOTween.To(() => player.position, x => player.position = x, player.position + Vector3.right, 0.3f);
                characterPlayer.Move(new Vector3(1, 1, 0));
                audioSource.volume = 0.2f;
                audioSource.PlayOneShot(dogde_sound);
            }
            else
            {
                //DOTween.To(() => player.position, x => player.position = x, player.position + Vector3.left, 0.3f);
                characterPlayer.Move(new Vector3(-1, 1, 0));
                audioSource.volume = 0.2f;
                audioSource.PlayOneShot(dogde_sound);
            }
        }
    }

   
    public void OnDrag(PointerEventData eventData)
    {

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.delta.x == 0)
        {
            characterPlayer.Move(new Vector3(0, 1.5f, 1));
            audioSource.volume = 0.2f;
            audioSource.PlayOneShot(jump_sound);
            //animator.SetTrigger("Jump");
        }
    }

    void FixedUpdate()
    {
        dir.y += gravity * Time.fixedDeltaTime;
        characterPlayer.Move(dir * Time.fixedDeltaTime);
    }
}