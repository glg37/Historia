using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlarsom : MonoBehaviour
{
    private bool estadoSom = true;
    private AudioSource fundoMusical;

    [SerializeField] private Sprite somLigadoSprite;
    [SerializeField] private Sprite somDesligadoSprite;

    public Image muteImage;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LigarDesligarSom()
    {
        estadoSom = !estadoSom;
        fundoMusical.enabled = estadoSom;
        if (estadoSom)
        {
            muteImage.sprite = somLigadoSprite;

        }
        else
        {
            muteImage.sprite = somDesligadoSprite;
        }

    }
    public void VolumeMusical(float value)
    {
        fundoMusical.volume = value;
    }
}
